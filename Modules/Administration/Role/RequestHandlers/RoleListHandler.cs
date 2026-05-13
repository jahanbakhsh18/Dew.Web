using MyRow = Dew.Administration.RoleRow;

namespace Dew.Administration;

public interface IRoleListHandler : IListHandler<MyRow> { }

public class RoleListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), IRoleListHandler
{
}