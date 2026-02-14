import { EntityDialog } from '@serenity-is/corelib';
import { ActionForm, ActionRow, ActionService } from '../../ServerTypes/WorkFlow';

export class ActionDialog extends EntityDialog<ActionRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.WorkFlow.");

    protected override getFormKey() { return ActionForm.formKey; }
    protected override getRowDefinition() { return ActionRow; }
    protected override getService() { return ActionService.baseUrl; }

    protected form = new ActionForm(this.idPrefix);
}