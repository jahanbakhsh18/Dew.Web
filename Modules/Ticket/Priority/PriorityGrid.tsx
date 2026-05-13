import { EntityGrid } from '@serenity-is/corelib';
import { PriorityColumns, PriorityRow, PriorityService } from '../../ServerTypes/Ticket';
import { PriorityDialog } from './PriorityDialog';

export class PriorityGrid extends EntityGrid<PriorityRow> {
    static override [Symbol.typeInfo] = this.registerClass("Dew.Ticket.");

    protected override getColumnsKey() { return PriorityColumns.columnsKey; }
    protected override getDialogType() { return PriorityDialog; }
    protected override getRowDefinition() { return PriorityRow; }
    protected override getService() { return PriorityService.baseUrl; }
}