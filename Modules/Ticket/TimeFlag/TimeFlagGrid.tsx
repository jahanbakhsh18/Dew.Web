import { EntityGrid } from '@serenity-is/corelib';
import { TimeFlagColumns, TimeFlagRow, TimeFlagService } from '../../ServerTypes/Ticket';
import { TimeFlagDialog } from './TimeFlagDialog';

export class TimeFlagGrid extends EntityGrid<TimeFlagRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getColumnsKey() { return TimeFlagColumns.columnsKey; }
    protected override getDialogType() { return TimeFlagDialog; }
    protected override getRowDefinition() { return TimeFlagRow; }
    protected override getService() { return TimeFlagService.baseUrl; }
}