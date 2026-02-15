import { fieldsProxy } from "@serenity-is/corelib";

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
    IsDeleted?: number[];
    IsValid?: number[];
    IsDomestic?: number[];
    SystemName?: string;
    ProblemName?: string;
    StatusName?: string;
    LastActionName?: string;
    TimeFlagName?: string;
    CreatorUserUsername?: string;
}

export abstract class TicketRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Ticket.Ticket';
    static readonly deletePermission = 'Ticketing:Ticket';
    static readonly insertPermission = 'Ticketing:Ticket';
    static readonly readPermission = 'Ticketing:Ticket';
    static readonly updatePermission = 'Ticketing:Ticket';

    static readonly Fields = fieldsProxy<TicketRow>();
}