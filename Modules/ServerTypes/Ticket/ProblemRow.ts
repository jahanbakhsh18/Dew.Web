import { fieldsProxy, getLookup, getLookupAsync } from "@serenity-is/corelib";

export interface ProblemRow {
    Id?: number;
    Name?: string;
    SystemId?: number;
    PriorityId?: number;
    SystemName?: string;
    PriorityName?: string;
    PriorityColor?: string;
}

export abstract class ProblemRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Ticket.Problem';
    static readonly lookupKey = 'Ticketing.Problem';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ProblemRow>('Ticketing.Problem') }
    static async getLookupAsync() { return getLookupAsync<ProblemRow>('Ticketing.Problem') }

    static readonly deletePermission = 'Ticketing:Ticket:Update';
    static readonly insertPermission = 'Ticketing:Ticket:Update';
    static readonly readPermission = 'Ticketing:Ticket:View';
    static readonly updatePermission = 'Ticketing:Ticket:Update';

    static readonly Fields = fieldsProxy<ProblemRow>();
}