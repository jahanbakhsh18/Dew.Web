import { fieldsProxy, getLookup, getLookupAsync } from "@serenity-is/corelib";

export interface SystemRow {
    Id?: number;
    Name?: string;
    Description?: string;
}

export abstract class SystemRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Ticket.System';
    static readonly lookupKey = 'Ticket.System';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SystemRow>('Ticket.System') }
    static async getLookupAsync() { return getLookupAsync<SystemRow>('Ticket.System') }

    static readonly deletePermission = 'Ticketing:Ticket:Update';
    static readonly insertPermission = 'Ticketing:Ticket:Update';
    static readonly readPermission = 'Ticketing:Ticket:View';
    static readonly updatePermission = 'Ticketing:Ticket:Update';

    static readonly Fields = fieldsProxy<SystemRow>();
}