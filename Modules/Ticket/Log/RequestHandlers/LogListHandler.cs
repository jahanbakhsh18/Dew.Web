using MyRow = Dew.Ticket.LogRow;

namespace Dew.Ticket;

public interface ILogListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class LogListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ILogListHandler
{
}