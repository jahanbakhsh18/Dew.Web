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
    Username?: string;
}

export abstract class LogRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Ticket.Log';
    static readonly deletePermission = 'Dew:Ticket:Admin';
    static readonly insertPermission = 'Dew:Ticket:Update';
    static readonly readPermission = 'Dew:Ticket:View';
    static readonly updatePermission = 'Dew:Ticket:Update';

    static readonly Fields = fieldsProxy<LogRow>();
}