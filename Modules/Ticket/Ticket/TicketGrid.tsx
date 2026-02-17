import { EntityGrid, QuickFilter, tryFirst, Widget } from '@serenity-is/corelib';
import { TicketColumns, TicketRow, TicketService } from '../../ServerTypes/Ticket';
import { TicketDialog } from './TicketDialog';

export class TicketGrid extends EntityGrid<TicketRow> {
    static override[Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getColumnsKey() { return TicketColumns.columnsKey; }
    protected override getDialogType() { return TicketDialog; }
    protected override getRowDefinition() { return TicketRow; }
    protected override getService() { return TicketService.baseUrl; }

    protected override getQuickFilters(): QuickFilter<Widget<any>, any>[] {
        var filters = super.getQuickFilters();

        var fld = TicketRow.Fields;

        var systemFilter = tryFirst(filters, f => f.field == fld.SystemId);
        systemFilter.cssClass = 'size-240';
        var problemFilter = tryFirst(filters, f => f.field == fld.ProblemId);
        problemFilter.cssClass = 'size-240';

        return filters;
    }
}