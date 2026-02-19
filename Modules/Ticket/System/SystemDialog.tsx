import { SystemForm, SystemRow, SystemService } from '../../ServerTypes/Ticket';
import { BaseEntityDialog } from '../../Common/Helpers/BaseEntityDialog';

export class SystemDialog extends BaseEntityDialog<SystemRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return SystemForm.formKey; }
    protected override getRowDefinition() { return SystemRow; }
    protected override getService() { return SystemService.baseUrl; }

    protected form = new SystemForm(this.idPrefix);
}