import { EntityGrid } from '@serenity-is/corelib';
import { ActionColumns, ActionRow, ActionService } from '../../ServerTypes/WorkFlow';
import { ActionDialog } from './ActionDialog';

export class ActionGrid extends EntityGrid<ActionRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.WorkFlow.");

    protected override getColumnsKey() { return ActionColumns.columnsKey; }
    protected override getDialogType() { return ActionDialog; }
    protected override getRowDefinition() { return ActionRow; }
    protected override getService() { return ActionService.baseUrl; }
}