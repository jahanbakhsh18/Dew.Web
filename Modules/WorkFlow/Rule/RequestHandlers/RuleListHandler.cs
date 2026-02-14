using MyRow = WorkFlow.RuleRow;

namespace WorkFlow;

public interface IRuleListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class RuleListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IRuleListHandler
{
}