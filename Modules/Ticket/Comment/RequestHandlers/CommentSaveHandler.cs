using MyRow = Ticketing.Ticket.CommentRow;

namespace Ticketing.Ticket;

public interface ICommentSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class CommentSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ICommentSaveHandler
{
    int userId = Convert.ToInt32(context.User.GetIdentifier());

    protected override void SetInternalFields()
    {
        base.SetInternalFields();

        if (IsCreate)
        {
            Row.UserId = userId;
            Row.DateCreated = DateTime.Now;
        }
    }
}