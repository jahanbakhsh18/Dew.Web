using MyRow = Ticketing.Administration.UserRow;

namespace Ticketing.Administration;

public interface IUserRetrieveHandler : IRetrieveHandler<MyRow> { }

public class UserRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), IUserRetrieveHandler
{
}