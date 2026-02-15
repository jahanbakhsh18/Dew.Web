import { EntityGrid } from '@serenity-is/corelib';
import { LogColumns, LogRow, LogService } from '../../ServerTypes/Ticket';
import { LogDialog } from './LogDialog';

export class LogGrid extends EntityGrid<LogRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getColumnsKey() { return LogColumns.columnsKey; }
    protected override getDialogType() { return LogDialog; }
    protected override getRowDefinition() { return LogRow; }
    protected override getService() { return LogService.baseUrl; }
}