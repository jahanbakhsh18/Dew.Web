using MyRow = Dew.Ticket.TicketRow;

namespace Dew.Ticket;

public interface ITicketRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class TicketRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ITicketRetrieveHandler
{
}