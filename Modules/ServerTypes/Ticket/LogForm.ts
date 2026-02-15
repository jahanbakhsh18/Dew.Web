import { DateEditor, initFormType, LookupEditor, PrefixedContext, ServiceLookupEditor } from "@serenity-is/corelib";

export interface LogForm {
    StatusId: LookupEditor;
    ActionId: LookupEditor;
    TicketId: ServiceLookupEditor;
    UserId: LookupEditor;
    DateCreated: DateEditor;
}

export class LogForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Log';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LogForm.init) {
            LogForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DateEditor;

            initFormType(LogForm, [
                'StatusId', w0,
                'ActionId', w0,
                'TicketId', w1,
                'UserId', w0,
                'DateCreated', w2
            ]);
        }
    }
}