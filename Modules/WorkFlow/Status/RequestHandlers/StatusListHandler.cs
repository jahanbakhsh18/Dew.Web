using MyRow = WorkFlow.StatusRow;

namespace WorkFlow;

public interface IStatusListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class StatusListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IStatusListHandler
{
}