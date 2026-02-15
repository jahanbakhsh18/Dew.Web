namespace Ticketing.Ticket.Pages;

[PageAuthorize(typeof(SystemRow))]
public class SystemPage : Controller
{
    [Route("Ticket/System")]
    public ActionResult Index()
    {
        return this.GridPage<SystemRow>("@/Ticket/System/SystemPage");
    }
}