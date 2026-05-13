using MyRow = Dew.Ticket.SystemRow;

namespace Dew.Ticket;

public interface ISystemSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class SystemSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ISystemSaveHandler
{
}