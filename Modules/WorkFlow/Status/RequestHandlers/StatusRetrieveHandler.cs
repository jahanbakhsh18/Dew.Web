using MyRow = WorkFlow.StatusRow;

namespace WorkFlow;

public interface IStatusRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class StatusRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IStatusRetrieveHandler
{
}