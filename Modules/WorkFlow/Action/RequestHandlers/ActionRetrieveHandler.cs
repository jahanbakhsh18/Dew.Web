using MyRow = WorkFlow.ActionRow;

namespace WorkFlow;

public interface IActionRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class ActionRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IActionRetrieveHandler
{
}