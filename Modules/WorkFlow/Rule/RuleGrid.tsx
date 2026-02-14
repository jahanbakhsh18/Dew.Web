import { EntityGrid } from '@serenity-is/corelib';
import { RuleColumns, RuleRow, RuleService } from '../../ServerTypes/WorkFlow';
import { RuleDialog } from './RuleDialog';

export class RuleGrid extends EntityGrid<RuleRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.WorkFlow.");

    protected override getColumnsKey() { return RuleColumns.columnsKey; }
    protected override getDialogType() { return RuleDialog; }
    protected override getRowDefinition() { return RuleRow; }
    protected override getService() { return RuleService.baseUrl; }
}