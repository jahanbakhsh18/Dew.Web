namespace WorkFlow.Pages;

[PageAuthorize(typeof(StatusRow))]
public class StatusPage : Controller
{
    [Route("WorkFlow/Status")]
    public ActionResult Index()
    {
        return this.GridPage<StatusRow>("@/WorkFlow/Status/StatusPage");
    }
}