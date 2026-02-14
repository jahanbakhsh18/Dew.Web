using MyRow = WorkFlow.StatusRow;

namespace WorkFlow;

public interface IStatusDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class StatusDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IStatusDeleteHandler
{
}