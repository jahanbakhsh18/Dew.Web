using MyRow = Ticketing.Ticket.CommentRow;

namespace Ticketing.Ticket;

public interface ICommentSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class CommentSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ICommentSaveHandler
{
}