import { fieldsProxy } from "@serenity-is/corelib";

export interface SystemRow {
    Id?: number;
    Name?: string;
    Description?: string;
}

export abstract class SystemRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Ticket.System';
    static readonly deletePermission = 'Ticketing:Ticket';
    static readonly insertPermission = 'Ticketing:Ticket';
    static readonly readPermission = 'Ticketing:Ticket';
    static readonly updatePermission = 'Ticketing:Ticket';

    static readonly Fields = fieldsProxy<SystemRow>();
}