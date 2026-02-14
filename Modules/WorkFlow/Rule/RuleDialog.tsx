import { EntityDialog } from '@serenity-is/corelib';
import { RuleForm, RuleRow, RuleService } from '../../ServerTypes/WorkFlow';

export class RuleDialog extends EntityDialog<RuleRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.WorkFlow.");

    protected override getFormKey() { return RuleForm.formKey; }
    protected override getRowDefinition() { return RuleRow; }
    protected override getService() { return RuleService.baseUrl; }

    protected form = new RuleForm(this.idPrefix);
}