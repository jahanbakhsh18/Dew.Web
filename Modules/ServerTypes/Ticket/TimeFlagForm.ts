import { initFormType, IntegerEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";
import { ColorPickerEditor } from "../../Ticket/Priority/ColorPickerEditor";

export interface TimeFlagForm {
    Name: StringEditor;
    DuePercent: IntegerEditor;
    Color: ColorPickerEditor;
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
            var w2 = ColorPickerEditor;

            initFormType(TimeFlagForm, [
                'Name', w0,
                'DuePercent', w1,
                'Color', w2,
                'Description', w0
            ]);
        }
    }
}