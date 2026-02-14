using MyRow = Ticketing.Administration.LanguageRow;

namespace Ticketing.Administration;

public interface ILanguageDeleteHandler : IDeleteHandler<MyRow> { }

public class LanguageDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), ILanguageDeleteHandler
{
}