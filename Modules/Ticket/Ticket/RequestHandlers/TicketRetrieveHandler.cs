using MyRow = Dew.Ticket.TicketRow;

namespace Dew.Ticket;

public interface ITicketRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class TicketRetrieveHandler(IRequestContext context, IUserRetrieveService userRetrieveService) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ITicketRetrieveHandler
{
    protected IUserRetrieveService _userRetrieveService { get; } =
        userRetrieveService ?? throw new ArgumentNullException(nameof(userRetrieveService));
    string userId = context.User.GetIdentifier();

    protected override void OnAfterExecuteQuery()
    {
        base.OnAfterExecuteQuery();

        var userDef = _userRetrieveService.ById(userId) as UserDefinition;
        var roleIds = userDef.RoleIds?.ToList() ?? new List<int>();
        bool isAdmin = roleIds.Contains(1);

        if (!roleIds.Any())
        {
            Row.AvailableActions = new List<AvailableAction>();
            return;
        }

        var rule = WorkFlow.RuleRow.Fields.As("r");
        var action = WorkFlow.ActionRow.Fields.As("a");

        BaseCriteria whereCriteria = rule.CurrentStatusId == Row.StatusId.Value;
        if (!isAdmin)
        {
            whereCriteria = whereCriteria && rule.RoleId.In(roleIds);
        }

        var query = new SqlQuery()
            .From(rule)
            .InnerJoin(action, rule.ActionId == action.Id)
            .Select(action.Id, "ActionId")
            .Select(action.Name)
            .Where(whereCriteria)
            .Distinct(true);

        var actions = Connection.Query<AvailableAction>(query).ToList();
        Row.AvailableActions = actions;
    }
}