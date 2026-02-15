import { initFormType, PrefixedContext, ServiceLookupEditor, StringEditor } from "@serenity-is/corelib";

export interface ProblemForm {
    Name: StringEditor;
    SystemId: ServiceLookupEditor;
    PriorityId: ServiceLookupEditor;
}

export class ProblemForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Problem';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProblemForm.init) {
            ProblemForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;

            initFormType(ProblemForm, [
                'Name', w0,
                'SystemId', w1,
                'PriorityId', w1
            ]);
        }
    }
}