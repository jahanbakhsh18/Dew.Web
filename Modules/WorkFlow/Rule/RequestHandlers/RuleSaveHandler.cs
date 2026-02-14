using MyRow = WorkFlow.RuleRow;

namespace WorkFlow;

public interface IRuleSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class RuleSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IRuleSaveHandler
{
    protected override void BeforeSave()
    {
        base.BeforeSave();
         
        Request.Entity.UpdateDate = DateTime.Now;
    }
}