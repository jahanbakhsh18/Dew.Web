import { initFormType, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface StatusForm {
    Name: StringEditor;
}

export class StatusForm extends PrefixedContext {
    static readonly formKey = 'WorkFlow.Status';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StatusForm.init) {
            StatusForm.init = true;

            var w0 = StringEditor;

            initFormType(StatusForm, [
                'Name', w0
            ]);
        }
    }
}