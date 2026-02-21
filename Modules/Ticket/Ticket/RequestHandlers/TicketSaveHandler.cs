using Ticketing.Administration;
using MyRow = Ticketing.Ticket.TicketRow;

namespace Ticketing.Ticket;

public interface ITicketSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class TicketSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ITicketSaveHandler
{
    int userId = Convert.ToInt32(context.User.GetIdentifier());

    protected override void ValidateEditableFields(HashSet<Field> editable)
    {
        // Workflow
        var nextStatus = Connection.List<WorkFlow.RuleRow>().FirstOrDefault(t => t.ActionId == Row.LastActionId && t.CurrentStatusId == Row.StatusId);

        if (nextStatus != null)
        {
            Row.StatusId = nextStatus.NextStatusId;

            if (nextStatus.IsFinalState == true)
                Row.DateClosed = DateTime.Now;
        }
        else
        {
            throw new ValidationError("AccessDenied", "This action is not defined in the workflow.");
        }

        base.ValidateEditableFields(editable);
    }

    protected override void ValidateRequired(HashSet<Field> editableFields)
    {
        if (IsCreate)
        {
            Row.DateCreated = DateTime.Now;
            Row.CreatorUserId = userId;
            Row.TimeFlagId = Connection.List<TimeFlagRow>().OrderBy(t => t.DuePercent).FirstOrDefault().Id;

            var problem = Connection.List<ProblemRow>().FirstOrDefault(p => p.Id == Row.ProblemId);
            var dueTime = Connection.List<PriorityRow>().Where(p => p.Id == problem.PriorityId).Select(d => d.DueTime).FirstOrDefault();
            Row.ExpireDate = Row.DateCreated.Value.AddHours(Convert.ToDouble(dueTime));
        }

        base.ValidateRequired(editableFields);
    }

    protected override void AfterSave()
    {
        base.AfterSave();

        LogRow newLog = new LogRow()
        {
            StatusId = Row.StatusId,
            ActionId = Row.LastActionId,
            TicketId = Row.Id,
            DateCreated = DateTime.Now,
            UserId = userId
        };

        Connection.Insert<LogRow>(newLog);
    }
}