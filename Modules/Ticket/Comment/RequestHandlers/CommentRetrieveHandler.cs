using MyRow = Ticketing.Ticket.CommentRow;

namespace Ticketing.Ticket;

public interface ICommentRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class CommentRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ICommentRetrieveHandler
{
}