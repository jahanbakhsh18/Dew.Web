import { EntityDialog } from '@serenity-is/corelib';
import { CommentForm, CommentRow, CommentService } from '../../ServerTypes/Ticket';

export class CommentDialog extends EntityDialog<CommentRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return CommentForm.formKey; }
    protected override getRowDefinition() { return CommentRow; }
    protected override getService() { return CommentService.baseUrl; }

    protected form = new CommentForm(this.idPrefix);
}