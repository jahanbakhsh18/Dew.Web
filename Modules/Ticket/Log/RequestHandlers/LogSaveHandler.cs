using MyRow = Ticketing.Ticket.LogRow;

namespace Ticketing.Ticket;

public interface ILogSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class LogSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ILogSaveHandler
{
}