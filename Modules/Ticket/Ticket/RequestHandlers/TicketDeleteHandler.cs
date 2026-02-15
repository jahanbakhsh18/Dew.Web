using MyRow = Ticketing.Ticket.TicketRow;

namespace Ticketing.Ticket;

public interface ITicketDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class TicketDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ITicketDeleteHandler
{
}