using MyRow = Ticketing.Ticket.ProblemRow;

namespace Ticketing.Ticket;

public interface IProblemDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class ProblemDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IProblemDeleteHandler
{
}