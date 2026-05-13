using MyRow = Dew.Ticket.ProblemRow;

namespace Dew.Ticket;

public interface IProblemDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class ProblemDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IProblemDeleteHandler
{
}