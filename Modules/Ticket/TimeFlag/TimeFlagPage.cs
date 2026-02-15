namespace Ticketing.Ticket.Pages;

[PageAuthorize(typeof(TimeFlagRow))]
public class TimeFlagPage : Controller
{
    [Route("Ticket/TimeFlag")]
    public ActionResult Index()
    {
        return this.GridPage<TimeFlagRow>("@/Ticket/TimeFlag/TimeFlagPage");
    }
}