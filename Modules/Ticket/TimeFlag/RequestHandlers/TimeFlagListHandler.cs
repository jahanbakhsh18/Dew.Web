using MyRow = Ticketing.Ticket.TimeFlagRow;

namespace Ticketing.Ticket;

public interface ITimeFlagListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class TimeFlagListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ITimeFlagListHandler
{
}