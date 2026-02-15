using MyRow = Ticketing.Ticket.TicketRow;

namespace Ticketing.Ticket;

public interface ITicketListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class TicketListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ITicketListHandler
{
}