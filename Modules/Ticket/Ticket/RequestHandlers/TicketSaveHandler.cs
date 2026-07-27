using Dew.Administration;
using MyRow = Dew.Ticket.TicketRow;

namespace Dew.Ticket;

public interface ITicketSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class TicketSaveHandler(IRequestContext context, IUserRetrieveService userRetrieveService) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ITicketSaveHandler
{
    protected IUserRetrieveService _userRetrieveService { get; } =
       userRetrieveService ?? throw new ArgumentNullException(nameof(userRetrieveService));
    int userId = Convert.ToInt32(context.User.GetIdentifier());

    protected override void ValidateEditableFields(HashSet<Field> editable)
    {
        if (IsUpdate && Row.StatusId != Old.StatusId)
            throw new ValidationError("AccessDenied", "The client status is not synced with the server!");

        var userDef = _userRetrieveService.ById(userId.ToString()) as UserDefinition;
        var roleIds = userDef.RoleIds?.ToList() ?? new List<int>();

        // Workflow
        var nextStatus = Connection.List<WorkFlow.RuleRow>().FirstOrDefault(t =>
            t.ActionId == Row.LastActionId
            && t.CurrentStatusId == Row.StatusId
            && (roleIds.Contains(t.RoleId.Value) || roleIds.Contains(1))
        );

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