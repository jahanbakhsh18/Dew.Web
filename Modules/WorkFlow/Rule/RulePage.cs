namespace WorkFlow.Pages;

[PageAuthorize(typeof(RuleRow))]
public class RulePage : Controller
{
    [Route("WorkFlow/Rule")]
    public ActionResult Index()
    {
        return this.GridPage<RuleRow>("@/WorkFlow/Rule/RulePage");
    }
}