import { EntityGrid } from '@serenity-is/corelib';
import { StatusColumns, StatusRow, StatusService } from '../../ServerTypes/WorkFlow';
import { StatusDialog } from './StatusDialog';

export class StatusGrid extends EntityGrid<StatusRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.WorkFlow.");

    protected override getColumnsKey() { return StatusColumns.columnsKey; }
    protected override getDialogType() { return StatusDialog; }
    protected override getRowDefinition() { return StatusRow; }
    protected override getService() { return StatusService.baseUrl; }
}