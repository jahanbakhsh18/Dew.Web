import { fieldsProxy, getLookup, getLookupAsync } from "@serenity-is/corelib";

export interface PriorityRow {
    Id?: number;
    DueTime?: number;
    Name?: string;
    Color?: string;
    Description?: string;
}

export abstract class PriorityRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Ticket.Priority';
    static readonly lookupKey = 'Ticketing.Priority';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PriorityRow>('Ticketing.Priority') }
    static async getLookupAsync() { return getLookupAsync<PriorityRow>('Ticketing.Priority') }

    static readonly deletePermission = 'Ticketing:Ticket:View';
    static readonly insertPermission = 'Ticketing:Ticket:Admin';
    static readonly readPermission = 'Ticketing:Ticket:View';
    static readonly updatePermission = 'Ticketing:Ticket:Admin';

    static readonly Fields = fieldsProxy<PriorityRow>();
}