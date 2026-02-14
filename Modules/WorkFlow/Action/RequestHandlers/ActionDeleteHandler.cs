using MyRow = WorkFlow.ActionRow;

namespace WorkFlow;

public interface IActionDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class ActionDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IActionDeleteHandler
{
}