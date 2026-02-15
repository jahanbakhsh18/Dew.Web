import { initFormType, IntegerEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface PriorityForm {
    DueTime: IntegerEditor;
    Name: StringEditor;
    IconName: StringEditor;
    Color: StringEditor;
    Description: StringEditor;
}

export class PriorityForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Priority';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PriorityForm.init) {
            PriorityForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(PriorityForm, [
                'DueTime', w0,
                'Name', w1,
                'IconName', w1,
                'Color', w1,
                'Description', w1
            ]);
        }
    }
}