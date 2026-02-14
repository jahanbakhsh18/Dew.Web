import { EntityDialog } from '@serenity-is/corelib';
import { StatusForm, StatusRow, StatusService } from '../../ServerTypes/WorkFlow';

export class StatusDialog extends EntityDialog<StatusRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.WorkFlow.");

    protected override getFormKey() { return StatusForm.formKey; }
    protected override getRowDefinition() { return StatusRow; }
    protected override getService() { return StatusService.baseUrl; }

    protected form = new StatusForm(this.idPrefix);
}