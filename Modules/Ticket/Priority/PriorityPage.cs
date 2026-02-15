namespace Ticketing.Ticket.Pages;

[PageAuthorize(typeof(PriorityRow))]
public class PriorityPage : Controller
{
    [Route("Ticket/Priority")]
    public ActionResult Index()
    {
        return this.GridPage<PriorityRow>("@/Ticket/Priority/PriorityPage");
    }
}