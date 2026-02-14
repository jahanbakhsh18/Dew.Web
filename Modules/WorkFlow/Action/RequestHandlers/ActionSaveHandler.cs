using MyRow = WorkFlow.ActionRow;

namespace WorkFlow;

public interface IActionSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class ActionSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IActionSaveHandler
{
    protected override void BeforeSave()
    {
        base.BeforeSave();
        
        Request.Entity.UpdateDate = DateTime.Now;
    }
}