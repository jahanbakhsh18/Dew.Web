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
    static readonly deletePermission = 'Dew:Ticket:Admin';
    static readonly insertPermission = 'Dew:Ticket:Admin';
    static readonly readPermission = 'Dew:Ticket:View';
    static readonly updatePermission = 'Dew:Ticket:Admin';

    static readonly Fields = fieldsProxy<TimeFlagRow>();
}