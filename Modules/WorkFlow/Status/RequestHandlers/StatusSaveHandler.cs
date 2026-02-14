using MyRow = WorkFlow.StatusRow;

namespace WorkFlow;

public interface IStatusSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class StatusSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IStatusSaveHandler
{
    protected override void BeforeSave()
    {
        base.BeforeSave();

        Request.Entity.UpdateDate = DateTime.Now;
    }

}