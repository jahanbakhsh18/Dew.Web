using MyRow = Ticketing.Ticket.ProblemRow;

namespace Ticketing.Ticket;

public interface IProblemRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class ProblemRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IProblemRetrieveHandler
{
}