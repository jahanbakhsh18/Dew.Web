using MyRow = Ticketing.Ticket.TimeFlagRow;

namespace Ticketing.Ticket;

public interface ITimeFlagSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class TimeFlagSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ITimeFlagSaveHandler
{
}