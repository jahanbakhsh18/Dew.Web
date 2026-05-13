using MyRow = Dew.Ticket.LogRow;

namespace Dew.Ticket;

public interface ILogDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class LogDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ILogDeleteHandler
{
}