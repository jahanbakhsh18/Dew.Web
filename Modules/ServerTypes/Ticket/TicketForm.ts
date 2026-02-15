import { DateEditor, initFormType, IntegerEditor, LookupEditor, PrefixedContext, ServiceLookupEditor, StringEditor } from "@serenity-is/corelib";

export interface TicketForm {
    TicketNumber: IntegerEditor;
    Title: StringEditor;
    Description: StringEditor;
    DateCreated: DateEditor;
    DateUpdated: DateEditor;
    DateClosed: DateEditor;
    SystemId: ServiceLookupEditor;
    ProblemId: ServiceLookupEditor;
    StatusId: LookupEditor;
    LastActionId: LookupEditor;
    TimeFlagId: ServiceLookupEditor;
    FilesPath: StringEditor;
    CreatorUserId: LookupEditor;
    ExpireDate: DateEditor;
    IsDeleted: StringEditor;
    IsValid: StringEditor;
    IsDomestic: StringEditor;
}

export class TicketForm extends PrefixedContext {
    static readonly formKey = 'Ticket.Ticket';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TicketForm.init) {
            TicketForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = ServiceLookupEditor;
            var w4 = LookupEditor;

            initFormType(TicketForm, [
                'TicketNumber', w0,
                'Title', w1,
                'Description', w1,
                'DateCreated', w2,
                'DateUpdated', w2,
                'DateClosed', w2,
                'SystemId', w3,
                'ProblemId', w3,
                'StatusId', w4,
                'LastActionId', w4,
                'TimeFlagId', w3,
                'FilesPath', w1,
                'CreatorUserId', w4,
                'ExpireDate', w2,
                'IsDeleted', w1,
                'IsValid', w1,
                'IsDomestic', w1
            ]);
        }
    }
}