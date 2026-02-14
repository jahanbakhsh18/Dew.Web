using MyRow = WorkFlow.ActionRow;

namespace WorkFlow;

public interface IActionListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class ActionListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IActionListHandler
{
}