import { DateEditor, initFormType, LookupEditor, PrefixedContext, ServiceLookupEditor, StringEditor } from "@serenity-is/corelib";

export interface CommentForm {
    Comment: StringEditor;
    TicketId: ServiceLookupEditor;
    UserId: LookupEditor;
    DateCreated: DateEditor;
}

export class CommentForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Comment';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CommentForm.init) {
            CommentForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = LookupEditor;
            var w3 = DateEditor;

            initFormType(CommentForm, [
                'Comment', w0,
                'TicketId', w1,
                'UserId', w2,
                'DateCreated', w3
            ]);
        }
    }
}