namespace Ticketing.Ticket.Pages;

[PageAuthorize(typeof(ProblemRow))]
public class ProblemPage : Controller
{
    [Route("Ticket/Problem")]
    public ActionResult Index()
    {
        return this.GridPage<ProblemRow>("@/Ticket/Problem/ProblemPage");
    }
}