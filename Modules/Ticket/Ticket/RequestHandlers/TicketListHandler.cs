using Dew.Administration;
using MyRow = Dew.Ticket.TicketRow;

namespace Dew.Ticket;

public interface ITicketListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class TicketListHandler(IRequestContext context, ITwoLevelCache cache) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ITicketListHandler
{
    private int userId = Convert.ToInt32(context.User.GetIdentifier());
    private readonly ITwoLevelCache cache = cache ?? throw new ArgumentNullException(nameof(cache));
    private static readonly object RefreshLock = new object();
    private static readonly TimeSpan RefreshInterval = TimeSpan.FromMinutes(10);

    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);
        
        // Querying UserRoleRow for every list request can be expensive
        var roleIds = Connection.List<UserRoleRow>()
            .Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();

        if (roleIds != null && roleIds.Count == 1 && roleIds.Contains(5))
            query.Where(MyRow.Fields.CreatorUserId == userId);
    }

    protected override void OnBeforeExecuteQuery()
    {
        base.OnBeforeExecuteQuery();

        cache.GetLocalStoreOnly( "TicketTimeFlagLastRefresh", RefreshInterval, "TicketTimeFlagRefreshGroup",
            loader: () =>
            {
                RefreshTimeFlags();
                return "OK"; // dummy value
            }
        );
    }

    private void RefreshTimeFlags()
    {
        lock (RefreshLock)
        {
            var flags = Connection.List<TimeFlagRow>()
                .Where(x => x.Id.HasValue && x.DuePercent.HasValue)
                .Select(x => (Id: x.Id.Value, DuePercent: x.DuePercent.Value))
                .ToList();

            if (!flags.Any()) return;

            var tickets = Connection.List<MyRow>()
                .Where(x => x.DateClosed == null && x.TimeFlagId != 4).ToList();

            if (!tickets.Any()) return;

            var now = DateTime.Now;
            foreach (var ticket in tickets)
            {
                var newFlagId = TimeFlagCalculator.GetTimeFlagId(
                    ticket.DateCreated.Value,
                    ticket.ExpireDate.Value,
                    flags,
                    now);

                if (newFlagId != ticket.TimeFlagId)
                {
                    ticket.TimeFlagId = newFlagId;
                    Connection.UpdateById(ticket);
                }
            }
        }
    }
}

public static class TimeFlagCalculator
{
    public static int? GetTimeFlagId(DateTime dateCreated, DateTime expireDate,
        IEnumerable<(int Id, int DuePercent)> flags, DateTime now)
    {
        if (flags == null || !flags.Any())
            return null;

        var totalSeconds = (expireDate - dateCreated).TotalSeconds;
        if (totalSeconds <= 0)
            return null; // expired

        var elapsedSeconds = (now - dateCreated).TotalSeconds;
        var elapsedPercent = elapsedSeconds / totalSeconds * 100;

        var best = flags
            .Where(f => f.DuePercent < elapsedPercent)
            .OrderByDescending(f => f.DuePercent)
            .FirstOrDefault();

        return best.Id;
    }
}