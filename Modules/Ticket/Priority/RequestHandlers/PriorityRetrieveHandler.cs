using MyRow = Dew.Ticket.PriorityRow;

namespace Dew.Ticket;

public interface IPriorityRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class PriorityRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IPriorityRetrieveHandler
{
}