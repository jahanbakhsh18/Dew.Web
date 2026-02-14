namespace WorkFlow.Pages;

[PageAuthorize(typeof(ActionRow))]
public class ActionPage : Controller
{
    [Route("WorkFlow/Action")]
    public ActionResult Index()
    {
        return this.GridPage<ActionRow>("@/WorkFlow/Action/ActionPage");
    }
}