import { BooleanEditor, initFormType, LookupEditor, PrefixedContext, ServiceLookupEditor } from "@serenity-is/corelib";

export interface RuleForm {
    RoleId: LookupEditor;
    CurrentStatusId: ServiceLookupEditor;
    ActionId: ServiceLookupEditor;
    NextStatusId: ServiceLookupEditor;
    IsFinalState: BooleanEditor;
}

export class RuleForm extends PrefixedContext {
    static readonly formKey = 'WorkFlow.Rule';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!RuleForm.init) {
            RuleForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = BooleanEditor;

            initFormType(RuleForm, [
                'RoleId', w0,
                'CurrentStatusId', w1,
                'ActionId', w1,
                'NextStatusId', w1,
                'IsFinalState', w2
            ]);
        }
    }
}