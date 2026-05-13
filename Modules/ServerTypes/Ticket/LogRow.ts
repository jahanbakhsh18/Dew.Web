import { fieldsProxy } from "@serenity-is/corelib";

export interface LogRow {
    Id?: number;
    StatusId?: number;
    ActionId?: number;
    TicketId?: number;
    UserId?: number;
    DateCreated?: string;
    StatusName?: string;
    ActionName?: string;
    TicketTitle?: string;
    Username?: string;
}

export abstract class LogRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Ticket.Log';
    static readonly deletePermission = 'Dew:Ticket';
    static readonly insertPermission = 'Dew:Ticket';
    static readonly readPermission = 'Dew:Ticket';
    static readonly updatePermission = 'Dew:Ticket';

    static readonly Fields = fieldsProxy<LogRow>();
}