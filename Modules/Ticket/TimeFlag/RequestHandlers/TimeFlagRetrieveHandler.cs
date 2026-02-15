using MyRow = Ticketing.Ticket.TimeFlagRow;

namespace Ticketing.Ticket;

public interface ITimeFlagRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class TimeFlagRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ITimeFlagRetrieveHandler
{
}