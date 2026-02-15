using MyRow = Ticketing.Ticket.PriorityRow;

namespace Ticketing.Ticket;

public interface IPriorityDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class PriorityDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IPriorityDeleteHandler
{
}