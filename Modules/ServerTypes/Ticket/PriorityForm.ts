import { initFormType, IntegerEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";
import { ColorPickerEditor } from "../../Ticket/Priority/ColorPickerEditor";

export interface PriorityForm {
    Name: StringEditor;
    Color: ColorPickerEditor;
    Description: StringEditor;
    DueTime: IntegerEditor;
}

export class PriorityForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Priority';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PriorityForm.init) {
            PriorityForm.init = true;

            var w0 = StringEditor;
            var w1 = ColorPickerEditor;
            var w2 = IntegerEditor;

            initFormType(PriorityForm, [
                'Name', w0,
                'Color', w1,
                'Description', w0,
                'DueTime', w2
            ]);
        }
    }
}