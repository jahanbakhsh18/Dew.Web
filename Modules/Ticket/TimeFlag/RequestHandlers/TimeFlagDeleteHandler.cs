using MyRow = Ticketing.Ticket.TimeFlagRow;

namespace Ticketing.Ticket;

public interface ITimeFlagDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class TimeFlagDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ITimeFlagDeleteHandler
{
}