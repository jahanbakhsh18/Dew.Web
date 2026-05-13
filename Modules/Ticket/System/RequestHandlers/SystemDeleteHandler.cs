using MyRow = Dew.Ticket.SystemRow;

namespace Dew.Ticket;

public interface ISystemDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class SystemDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ISystemDeleteHandler
{
}