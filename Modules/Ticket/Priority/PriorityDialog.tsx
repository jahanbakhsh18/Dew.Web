import { EntityDialog } from '@serenity-is/corelib';
import { PriorityForm, PriorityRow, PriorityService } from '../../ServerTypes/Ticket';

export class PriorityDialog extends EntityDialog<PriorityRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return PriorityForm.formKey; }
    protected override getRowDefinition() { return PriorityRow; }
    protected override getService() { return PriorityService.baseUrl; }

    protected form = new PriorityForm(this.idPrefix);
}