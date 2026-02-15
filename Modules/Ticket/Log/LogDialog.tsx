import { EntityDialog } from '@serenity-is/corelib';
import { LogForm, LogRow, LogService } from '../../ServerTypes/Ticket';

export class LogDialog extends EntityDialog<LogRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return LogForm.formKey; }
    protected override getRowDefinition() { return LogRow; }
    protected override getService() { return LogService.baseUrl; }

    protected form = new LogForm(this.idPrefix);
}