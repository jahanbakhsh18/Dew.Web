import { EntityGrid } from '@serenity-is/corelib';
import { ProblemColumns, ProblemRow, ProblemService } from '../../ServerTypes/Ticket';
import { ProblemDialog } from './ProblemDialog';

export class ProblemGrid extends EntityGrid<ProblemRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getColumnsKey() { return ProblemColumns.columnsKey; }
    protected override getDialogType() { return ProblemDialog; }
    protected override getRowDefinition() { return ProblemRow; }
    protected override getService() { return ProblemService.baseUrl; }
}