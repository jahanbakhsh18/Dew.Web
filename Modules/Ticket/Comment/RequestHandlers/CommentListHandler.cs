using MyRow = Ticketing.Ticket.CommentRow;

namespace Ticketing.Ticket;

public interface ICommentListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class CommentListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ICommentListHandler
{
}