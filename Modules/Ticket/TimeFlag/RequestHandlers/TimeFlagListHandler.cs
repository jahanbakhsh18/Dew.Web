using MyRow = Dew.Ticket.TimeFlagRow;

namespace Dew.Ticket;

public interface ITimeFlagListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class TimeFlagListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ITimeFlagListHandler
{
}