import { fieldsProxy } from "@serenity-is/corelib";
import { CommentRow } from "./CommentRow";

export interface TicketRow {
    Id?: number;
    TicketNumber?: number;
    Title?: string;
    Description?: string;
    DateCreated?: string;
    DateUpdated?: string;
    DateClosed?: string;
    SystemId?: number;
    ProblemId?: number;
    StatusId?: number;
    LastActionId?: number;
    TimeFlagId?: number;
    FilesPath?: string;
    CreatorUserId?: number;
    ExpireDate?: string;
    SystemName?: string;
    ProblemName?: string;
    StatusName?: string;
    LastActionName?: string;
    TimeFlagColor?: string;
    CreatorUsername?: string;
    CommentList?: CommentRow[];
}

export abstract class TicketRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Ticket.Ticket';
    static readonly deletePermission = 'Dew:Ticket:Update';
    static readonly insertPermission = 'Dew:Ticket:Update';
    static readonly readPermission = 'Dew:Ticket:View';
    static readonly updatePermission = 'Dew:Ticket:Update';

    static readonly Fields = fieldsProxy<TicketRow>();
}