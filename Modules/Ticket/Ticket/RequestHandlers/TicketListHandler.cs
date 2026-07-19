using Dew.Administration;
using MyRow = Dew.Ticket.TicketRow;

namespace Dew.Ticket;

public interface ITicketListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class TicketListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ITicketListHandler
{
    int userId = Convert.ToInt32(context.User.GetIdentifier());

    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);
        
        // Querying UserRoleRow for every list request can be expensive
        var roleIds = Connection.List<UserRoleRow>()
            .Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();

        if (roleIds != null && roleIds.Count == 1 && roleIds.Contains(5))
            query.Where( MyRow.Fields.CreatorUserId == userId);
    }
}