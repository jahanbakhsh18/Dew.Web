import { fieldsProxy } from "@serenity-is/corelib";
import { AvailableAction } from "./AvailableAction";
import { CommentRow } from "./CommentRow";

export interface TicketRow {
    Id?: number;
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
    AvailableActions?: AvailableAction[];
    HasAvailableActions?: boolean;
}

export abstract class TicketRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Ticket.Ticket';
    static readonly deletePermission = 'Dew:Ticket:Admin';
    static readonly insertPermission = 'Dew:Ticket:Create';
    static readonly readPermission = 'Dew:Ticket:View';
    static readonly updatePermission = 'Dew:Ticket:Update';

    static readonly Fields = fieldsProxy<TicketRow>();
}