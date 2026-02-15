namespace Ticketing.Ticket.Pages;

[PageAuthorize(typeof(CommentRow))]
public class CommentPage : Controller
{
    [Route("Ticket/Comment")]
    public ActionResult Index()
    {
        return this.GridPage<CommentRow>("@/Ticket/Comment/CommentPage");
    }
}