import { CommentForm, CommentRow, CommentService } from '../../ServerTypes/Ticket';
import { GridEditorDialog } from '@serenity-is/extensions';

export class CommentDialog extends GridEditorDialog<CommentRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return CommentForm.formKey; }
    protected override getRowDefinition() { return CommentRow; }
    protected override getService() { return CommentService.baseUrl; }

    protected form = new CommentForm(this.idPrefix);
}