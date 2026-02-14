using MyRow = Ticketing.Administration.LanguageRow;

namespace Ticketing.Administration;

public interface ILanguageListHandler : IListHandler<MyRow> { }

public class LanguageListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), ILanguageListHandler
{
}