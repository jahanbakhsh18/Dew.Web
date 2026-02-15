using MyRow = Ticketing.Ticket.PriorityRow;

namespace Ticketing.Ticket;

public interface IPriorityListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class PriorityListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IPriorityListHandler
{
}