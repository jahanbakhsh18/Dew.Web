import { fieldsProxy } from "@serenity-is/corelib";

export interface PriorityRow {
    Id?: number;
    DueTime?: number;
    Name?: string;
    IconName?: string;
    Color?: string;
    Description?: string;
}

export abstract class PriorityRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Ticket.Priority';
    static readonly deletePermission = 'Ticketing:Ticket';
    static readonly insertPermission = 'Ticketing:Ticket';
    static readonly readPermission = 'Ticketing:Ticket';
    static readonly updatePermission = 'Ticketing:Ticket';

    static readonly Fields = fieldsProxy<PriorityRow>();
}