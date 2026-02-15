using MyRow = Ticketing.Ticket.ProblemRow;

namespace Ticketing.Ticket;

public interface IProblemSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class ProblemSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IProblemSaveHandler
{
}