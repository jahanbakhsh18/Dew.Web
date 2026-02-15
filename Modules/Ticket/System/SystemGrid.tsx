import { EntityGrid } from '@serenity-is/corelib';
import { SystemColumns, SystemRow, SystemService } from '../../ServerTypes/Ticket';
import { SystemDialog } from './SystemDialog';

export class SystemGrid extends EntityGrid<SystemRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getColumnsKey() { return SystemColumns.columnsKey; }
    protected override getDialogType() { return SystemDialog; }
    protected override getRowDefinition() { return SystemRow; }
    protected override getService() { return SystemService.baseUrl; }
}