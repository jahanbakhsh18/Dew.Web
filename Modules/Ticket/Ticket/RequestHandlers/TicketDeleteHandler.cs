using Ticketing.Ticket.Endpoints;
using MyRow = Ticketing.Ticket.TicketRow;

namespace Ticketing.Ticket;

public interface ITicketDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class TicketDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ITicketDeleteHandler
{
    // Without OnDelete(Rule.Cascade)
    /*protected override void OnBeforeDelete()
    {
        base.OnBeforeDelete();

        var lr = LogRow.Fields;
        foreach (var itemId in Connection.Query<Int32>(new SqlQuery().From(lr).Select(lr.Id).Where(lr.TicketId == Row.Id.Value)))
        {            
            Connection.DeleteById<LogRow>(itemId);
        }

        var cm = CommentRow.Fields;
        foreach (var itemId in Connection.Query<Int32>(new SqlQuery().From(cm).Select(cm.Id).Where(cm.TicketId == Row.Id.Value)))
        {
            Connection.DeleteById<CommentRow>(itemId);
        }
    }*/
}