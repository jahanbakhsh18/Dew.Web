import { initFormType, IntegerEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface CommentForm {
    Comment: StringEditor;
    TicketId: IntegerEditor;
}

export class CommentForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Comment';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CommentForm.init) {
            CommentForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(CommentForm, [
                'Comment', w0,
                'TicketId', w1
            ]);
        }
    }
}