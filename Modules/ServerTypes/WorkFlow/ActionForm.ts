import { initFormType, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface ActionForm {
    Name: StringEditor;
}

export class ActionForm extends PrefixedContext {
    static readonly formKey = 'WorkFlow.Action';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ActionForm.init) {
            ActionForm.init = true;

            var w0 = StringEditor;

            initFormType(ActionForm, [
                'Name', w0
            ]);
        }
    }
}