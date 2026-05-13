using MyRow = Dew.Ticket.PriorityRow;

namespace Dew.Ticket;

public interface IPrioritySaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class PrioritySaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IPrioritySaveHandler
{
}