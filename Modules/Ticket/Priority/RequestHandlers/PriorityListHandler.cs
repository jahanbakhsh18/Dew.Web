using MyRow = Dew.Ticket.PriorityRow;

namespace Dew.Ticket;

public interface IPriorityListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class PriorityListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IPriorityListHandler
{
}