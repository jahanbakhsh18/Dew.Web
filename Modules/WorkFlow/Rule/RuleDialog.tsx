import { BaseEntityDialog } from '../../Common/Helpers/BaseEntityDialog';
import { RuleForm, RuleRow, RuleService } from '../../ServerTypes/WorkFlow';

export class RuleDialog extends BaseEntityDialog<RuleRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Dew.WorkFlow.");

    protected override getFormKey() { return RuleForm.formKey; }
    protected override getRowDefinition() { return RuleRow; }
    protected override getService() { return RuleService.baseUrl; }

    protected form = new RuleForm(this.idPrefix);
}