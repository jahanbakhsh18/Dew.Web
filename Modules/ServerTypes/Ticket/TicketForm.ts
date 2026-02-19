import { initFormType, LookupEditor, MultipleImageUploadEditor, PrefixedContext, TextAreaEditor } from "@serenity-is/corelib";
import { CommentListEditor } from "../../Ticket/Comment/CommentListEditor";

export interface TicketForm {
    SystemId: LookupEditor;
    ProblemId: LookupEditor;
    Description: TextAreaEditor;
    CommentList: CommentListEditor;
    FilesPath: MultipleImageUploadEditor;
    StatusId: LookupEditor;
    LastActionId: LookupEditor;
}

export class TicketForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Ticket';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TicketForm.init) {
            TicketForm.init = true;

            var w0 = LookupEditor;
            var w1 = TextAreaEditor;
            var w2 = CommentListEditor;
            var w3 = MultipleImageUploadEditor;

            initFormType(TicketForm, [
                'SystemId', w0,
                'ProblemId', w0,
                'Description', w1,
                'CommentList', w2,
                'FilesPath', w3,
                'StatusId', w0,
                'LastActionId', w0
            ]);
        }
    }
}