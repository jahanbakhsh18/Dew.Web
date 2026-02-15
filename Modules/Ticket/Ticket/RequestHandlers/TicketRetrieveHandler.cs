using MyRow = Ticketing.Ticket.TicketRow;

namespace Ticketing.Ticket;

public interface ITicketRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class TicketRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ITicketRetrieveHandler
{
}