import { EntityGrid } from '@serenity-is/corelib';
import { TicketColumns, TicketRow, TicketService } from '../../ServerTypes/Ticket';
import { TicketDialog } from './TicketDialog';

export class TicketGrid extends EntityGrid<TicketRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getColumnsKey() { return TicketColumns.columnsKey; }
    protected override getDialogType() { return TicketDialog; }
    protected override getRowDefinition() { return TicketRow; }
    protected override getService() { return TicketService.baseUrl; }
}