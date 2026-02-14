using MyRow = WorkFlow.RuleRow;

namespace WorkFlow;

public interface IRuleDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class RuleDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IRuleDeleteHandler
{
}