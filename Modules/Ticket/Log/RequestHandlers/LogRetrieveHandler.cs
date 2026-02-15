using MyRow = Ticketing.Ticket.LogRow;

namespace Ticketing.Ticket;

public interface ILogRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class LogRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ILogRetrieveHandler
{
}