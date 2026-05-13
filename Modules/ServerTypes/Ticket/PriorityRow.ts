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
    static readonly lookupKey = 'Dew.Priority';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PriorityRow>('Dew.Priority') }
    static async getLookupAsync() { return getLookupAsync<PriorityRow>('Dew.Priority') }

    static readonly deletePermission = 'Dew:Ticket:View';
    static readonly insertPermission = 'Dew:Ticket:Admin';
    static readonly readPermission = 'Dew:Ticket:View';
    static readonly updatePermission = 'Dew:Ticket:Admin';

    static readonly Fields = fieldsProxy<PriorityRow>();
}