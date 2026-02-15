import { EntityDialog } from '@serenity-is/corelib';
import { SystemForm, SystemRow, SystemService } from '../../ServerTypes/Ticket';

export class SystemDialog extends EntityDialog<SystemRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return SystemForm.formKey; }
    protected override getRowDefinition() { return SystemRow; }
    protected override getService() { return SystemService.baseUrl; }

    protected form = new SystemForm(this.idPrefix);
}