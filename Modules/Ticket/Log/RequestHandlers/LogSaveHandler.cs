using MyRow = Dew.Ticket.LogRow;

namespace Dew.Ticket;

public interface ILogSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class LogSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ILogSaveHandler
{
}