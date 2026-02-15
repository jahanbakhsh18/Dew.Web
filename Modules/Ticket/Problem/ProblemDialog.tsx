import { EntityDialog } from '@serenity-is/corelib';
import { ProblemForm, ProblemRow, ProblemService } from '../../ServerTypes/Ticket';

export class ProblemDialog extends EntityDialog<ProblemRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return ProblemForm.formKey; }
    protected override getRowDefinition() { return ProblemRow; }
    protected override getService() { return ProblemService.baseUrl; }

    protected form = new ProblemForm(this.idPrefix);
}