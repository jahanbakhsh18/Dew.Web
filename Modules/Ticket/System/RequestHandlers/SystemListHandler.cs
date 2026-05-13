using MyRow = Dew.Ticket.SystemRow;

namespace Dew.Ticket;

public interface ISystemListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class SystemListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ISystemListHandler
{
}