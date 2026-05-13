using MyRow = Dew.Ticket.SystemRow;

namespace Dew.Ticket;

public interface ISystemRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class SystemRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ISystemRetrieveHandler
{
}