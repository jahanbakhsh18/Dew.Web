using MyRow = Dew.Ticket.PriorityRow;

namespace Dew.Ticket;

public interface IPriorityDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class PriorityDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IPriorityDeleteHandler
{
}