import { EntityGrid } from '@serenity-is/corelib';
import { CommentColumns, CommentRow, CommentService } from '../../ServerTypes/Ticket';
import { CommentDialog } from './CommentDialog';

export class CommentGrid extends EntityGrid<CommentRow> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getColumnsKey() { return CommentColumns.columnsKey; }
    protected override getDialogType() { return CommentDialog; }
    protected override getRowDefinition() { return CommentRow; }
    protected override getService() { return CommentService.baseUrl; }
}