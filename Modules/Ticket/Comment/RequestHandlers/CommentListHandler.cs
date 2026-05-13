using MyRow = Dew.Ticket.CommentRow;

namespace Dew.Ticket;

public interface ICommentListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class CommentListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ICommentListHandler
{
}