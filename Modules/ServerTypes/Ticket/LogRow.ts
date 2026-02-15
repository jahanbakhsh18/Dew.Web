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
    static readonly deletePermission = 'Ticketing:Ticket';
    static readonly insertPermission = 'Ticketing:Ticket';
    static readonly readPermission = 'Ticketing:Ticket';
    static readonly updatePermission = 'Ticketing:Ticket';

    static readonly Fields = fieldsProxy<LogRow>();
}