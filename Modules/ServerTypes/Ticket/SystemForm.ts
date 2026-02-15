import { initFormType, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface SystemForm {
    Name: StringEditor;
    Description: StringEditor;
}

export class SystemForm extends PrefixedContext {
    static readonly formKey = 'Ticket.System';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SystemForm.init) {
            SystemForm.init = true;

            var w0 = StringEditor;

            initFormType(SystemForm, [
                'Name', w0,
                'Description', w0
            ]);
        }
    }
}