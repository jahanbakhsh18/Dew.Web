import { initFormType, IntegerEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface TimeFlagForm {
    Name: StringEditor;
    DuePercent: IntegerEditor;
    IconName: StringEditor;
    Color: StringEditor;
    Description: StringEditor;
}

export class TimeFlagForm extends PrefixedContext {
    static readonly formKey = 'Ticket.TimeFlag';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TimeFlagForm.init) {
            TimeFlagForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(TimeFlagForm, [
                'Name', w0,
                'DuePercent', w1,
                'IconName', w0,
                'Color', w0,
                'Description', w0
            ]);
        }
    }
}