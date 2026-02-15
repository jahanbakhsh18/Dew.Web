using MyRow = Ticketing.Ticket.TicketRow;

namespace Ticketing.Ticket;

public interface ITicketSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class TicketSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ITicketSaveHandler
{
}