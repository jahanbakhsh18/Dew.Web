using MyRow = Ticketing.Administration.RoleRow;

namespace Ticketing.Administration;

public interface IRoleListHandler : IListHandler<MyRow> { }

public class RoleListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), IRoleListHandler
{
}