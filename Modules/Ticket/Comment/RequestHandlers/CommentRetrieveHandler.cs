using MyRow = Dew.Ticket.CommentRow;

namespace Dew.Ticket;

public interface ICommentRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class CommentRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ICommentRetrieveHandler
{
}