using MyRow = Ticketing.Ticket.PriorityRow;

namespace Ticketing.Ticket;

public interface IPrioritySaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class PrioritySaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IPrioritySaveHandler
{
}