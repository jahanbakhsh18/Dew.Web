import { EntityGrid, QuickFilter, tryFirst, Widget } from '@serenity-is/corelib';
import { ProblemColumns, ProblemRow, ProblemService } from '../../ServerTypes/Ticket';
import { ProblemDialog } from './ProblemDialog';

export class ProblemGrid extends EntityGrid<ProblemRow> {
    static override[Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getColumnsKey() { return ProblemColumns.columnsKey; }
    protected override getDialogType() { return ProblemDialog; }
    protected override getRowDefinition() { return ProblemRow; }
    protected override getService() { return ProblemService.baseUrl; }

    protected override getQuickFilters(): QuickFilter<Widget<any>, any>[] {
        var filters = super.getQuickFilters();

        console.log(filters);

        var fld = ProblemRow.Fields;

        var systemFilter = tryFirst(filters, f => f.field == fld.SystemId);
        console.log(systemFilter);
        systemFilter.cssClass = 'size-240';

        return filters;
    }

}