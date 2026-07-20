
namespace Dew.Common.Pages;

[Route("Dashboard/[action]")]
public class DashboardPage : Controller
{
    [PageAuthorize, HttpGet, Route("~/")]
    public ActionResult Index([FromServices] ISqlConnections sqlConnections)
    {
        return View(MVC.Views.Common.Dashboard.DashboardIndex, BuildModel(sqlConnections));
    }

    private DashboardPageModel BuildModel(ISqlConnections sqlConnections)
    {
        ArgumentNullException.ThrowIfNull(sqlConnections);

        using var connection = sqlConnections.NewFor<Ticket.TicketRow>();
        var t = Ticket.TicketRow.Fields;

        var userId = Convert.ToInt32(User.GetIdentifier());

        var roleIds = connection.List<Administration.UserRoleRow>()
            .Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();

        // RoleId 5 == "User" role only see their own tickets.
        var restrictToOwnTickets = roleIds != null && roleIds.Count == 1 && roleIds.Contains(5);

        var query = connection.List<Ticket.TicketRow>(q =>
        {
            q.Select(t.Id, t.StatusName, t.SystemName, t.TimeFlagId, t.DateCreated, t.DateClosed);

            if (restrictToOwnTickets)
                q.Where(t.CreatorUserId == userId);
        });

        var model = new DashboardPageModel();

        var total = query.Count;
        var closedCount = query.Count(x => x.DateClosed != null);
        model.OpenTickets = total - closedCount;
        model.ClosedTicketPercent = total == 0 ? 0 : (int)Math.Round(100.0 * closedCount / total);

        model.SystemCount = connection.Count<Ticket.SystemRow>();
        model.ProblemCount = connection.Count<Ticket.ProblemRow>();

        model.TicketsByStatus = query
            .GroupBy(x => x.StatusName ?? "-")
            .Select(g => new StatusCountModel { StatusName = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count)
            .ToList();

        model.TicketsBySystem = query
            .GroupBy(x => x.SystemName ?? "-")
            .Select(g => new NameCountModel { Name = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count)
            .ToList();

        var timeFlags = connection.List<Dew.Ticket.TimeFlagRow>()
            .Where(x => x.Id != null)
            .ToDictionary(x => x.Id.Value, x => x);

        model.TicketsByTimeFlag = query
            .Where(x => x.TimeFlagId != null && timeFlags.ContainsKey(x.TimeFlagId.Value))
            .GroupBy(x => x.TimeFlagId.Value)
            .Select(g => new TimeFlagCountModel
            {
                Name = timeFlags[g.Key].Name,
                Color = timeFlags[g.Key].Color,
                Count = g.Count()
            })
            .ToList();

        var from = DateTime.Today.AddDays(-13);
        var byDay = query
            .Where(x => x.DateCreated != null && x.DateCreated.Value.Date >= from)
            .GroupBy(x => x.DateCreated.Value.Date)
            .ToDictionary(g => g.Key, g => g.Count());

        model.TicketsLast14Days = Enumerable.Range(0, 14).Select(i => from.AddDays(i))
            .Select(d => new DailyCountModel
            {
                Date = d.ToString("MM/dd"),
                Count = byDay.TryGetValue(d, out var c) ? c : 0
            })
            .ToList();

        return model;
    }
}