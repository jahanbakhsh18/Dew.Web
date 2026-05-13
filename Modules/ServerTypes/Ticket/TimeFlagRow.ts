import { fieldsProxy } from "@serenity-is/corelib";

export interface TimeFlagRow {
    Id?: number;
    Name?: string;
    DuePercent?: number;
    Color?: string;
    Description?: string;
}

export abstract class TimeFlagRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Ticket.TimeFlag';
    static readonly deletePermission = 'Dew:Ticket';
    static readonly insertPermission = 'Dew:Ticket';
    static readonly readPermission = 'Dew:Ticket';
    static readonly updatePermission = 'Dew:Ticket';

    static readonly Fields = fieldsProxy<TimeFlagRow>();
}