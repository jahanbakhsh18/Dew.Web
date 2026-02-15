namespace Ticketing.Ticket.Pages;

[PageAuthorize(typeof(TicketRow))]
public class TicketPage : Controller
{
    [Route("Ticket/Ticket")]
    public ActionResult Index()
    {
        return this.GridPage<TicketRow>("@/Ticket/Ticket/TicketPage");
    }
}