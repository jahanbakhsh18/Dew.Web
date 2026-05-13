using MyRow = Dew.Ticket.TimeFlagRow;

namespace Dew.Ticket;

public interface ITimeFlagDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class TimeFlagDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ITimeFlagDeleteHandler
{
}