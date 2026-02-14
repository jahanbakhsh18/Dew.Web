using MyRow = Ticketing.Administration.LanguageRow;

namespace Ticketing.Administration;

public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow> { }

public class LanguageRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), ILanguageRetrieveHandler
{
}