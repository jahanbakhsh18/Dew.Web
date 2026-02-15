import { EntityDialog } from '@serenity-is/corelib';
import { TimeFlagForm, TimeFlagRow, TimeFlagService } from '../../ServerTypes/Ticket';

export class TimeFlagDialog extends EntityDialog<TimeFlagRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return TimeFlagForm.formKey; }
    protected override getRowDefinition() { return TimeFlagRow; }
    protected override getService() { return TimeFlagService.baseUrl; }

    protected form = new TimeFlagForm(this.idPrefix);
}