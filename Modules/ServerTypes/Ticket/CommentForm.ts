import { initFormType, IntegerEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface CommentForm {
    Id: IntegerEditor;
    Comment: StringEditor;
}

export class CommentForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Comment';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CommentForm.init) {
            CommentForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(CommentForm, [
                'Id', w0,
                'Comment', w1
            ]);
        }
    }
}