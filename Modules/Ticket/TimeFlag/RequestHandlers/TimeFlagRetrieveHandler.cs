using MyRow = Dew.Ticket.TimeFlagRow;

namespace Dew.Ticket;

public interface ITimeFlagRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class TimeFlagRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ITimeFlagRetrieveHandler
{
}