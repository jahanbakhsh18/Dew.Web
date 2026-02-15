using MyRow = Ticketing.Ticket.LogRow;

namespace Ticketing.Ticket;

public interface ILogDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class LogDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ILogDeleteHandler
{
}