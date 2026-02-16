import { initFormType, LookupEditor, PrefixedContext, ServiceLookupEditor, TextAreaEditor } from "@serenity-is/corelib";

export interface TicketForm {
    SystemId: ServiceLookupEditor;
    ProblemId: ServiceLookupEditor;
    Description: TextAreaEditor;
    StatusId: LookupEditor;
    LastActionId: LookupEditor;
}

export class TicketForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Ticket';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TicketForm.init) {
            TicketForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = TextAreaEditor;
            var w2 = LookupEditor;

            initFormType(TicketForm, [
                'SystemId', w0,
                'ProblemId', w0,
                'Description', w1,
                'StatusId', w2,
                'LastActionId', w2
            ]);
        }
    }
}