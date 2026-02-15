namespace Ticketing.Ticket.Pages;

[PageAuthorize(typeof(LogRow))]
public class LogPage : Controller
{
    [Route("Ticket/Log")]
    public ActionResult Index()
    {
        return this.GridPage<LogRow>("@/Ticket/Log/LogPage");
    }
}