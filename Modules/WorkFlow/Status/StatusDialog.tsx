import { BaseEntityDialog } from '../../Common/Helpers/BaseEntityDialog';
import { StatusForm, StatusRow, StatusService } from '../../ServerTypes/WorkFlow';

export class StatusDialog extends BaseEntityDialog<StatusRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Dew.WorkFlow.");

    protected override getFormKey() { return StatusForm.formKey; }
    protected override getRowDefinition() { return StatusRow; }
    protected override getService() { return StatusService.baseUrl; }

    protected form = new StatusForm(this.idPrefix);
}