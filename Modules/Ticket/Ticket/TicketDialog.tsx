import { EntityDialog } from '@serenity-is/corelib';
import { TicketForm, TicketRow, TicketService } from '../../ServerTypes/Ticket';

export class TicketDialog extends EntityDialog<TicketRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return TicketForm.formKey; }
    protected override getRowDefinition() { return TicketRow; }
    protected override getService() { return TicketService.baseUrl; }

    protected form = new TicketForm(this.idPrefix);
}