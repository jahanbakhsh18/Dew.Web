using MyRow = Ticketing.Ticket.ProblemRow;

namespace Ticketing.Ticket;

public interface IProblemListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class ProblemListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IProblemListHandler
{
}