using MyRow = Ticketing.Ticket.CommentRow;

namespace Ticketing.Ticket;

public interface ICommentDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class CommentDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ICommentDeleteHandler
{
}