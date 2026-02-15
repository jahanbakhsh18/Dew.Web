import { fieldsProxy } from "@serenity-is/corelib";

export interface TimeFlagRow {
    Id?: number;
    Name?: string;
    DuePercent?: number;
    IconName?: string;
    Color?: string;
    Description?: string;
}

export abstract class TimeFlagRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Ticket.TimeFlag';
    static readonly deletePermission = 'Ticketing:Ticket';
    static readonly insertPermission = 'Ticketing:Ticket';
    static readonly readPermission = 'Ticketing:Ticket';
    static readonly updatePermission = 'Ticketing:Ticket';

    static readonly Fields = fieldsProxy<TimeFlagRow>();
}