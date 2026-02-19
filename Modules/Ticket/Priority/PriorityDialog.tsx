import { PriorityForm, PriorityRow, PriorityService } from '../../ServerTypes/Ticket';
import { BaseEntityDialog } from '../../Common/Helpers/BaseEntityDialog';

export class PriorityDialog extends BaseEntityDialog<PriorityRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return PriorityForm.formKey; }
    protected override getRowDefinition() { return PriorityRow; }
    protected override getService() { return PriorityService.baseUrl; }

    protected form = new PriorityForm(this.idPrefix);
}