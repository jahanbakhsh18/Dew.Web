using MyRow = WorkFlow.RuleRow;

namespace WorkFlow;

public interface IRuleRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class RuleRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IRuleRetrieveHandler
{
}