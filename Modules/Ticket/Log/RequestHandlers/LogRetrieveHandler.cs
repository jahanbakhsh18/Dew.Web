using MyRow = Dew.Ticket.LogRow;

namespace Dew.Ticket;

public interface ILogRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class LogRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ILogRetrieveHandler
{
}