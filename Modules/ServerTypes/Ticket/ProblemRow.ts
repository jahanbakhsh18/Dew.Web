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
    static readonly lookupKey = 'Ticket.Problem';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ProblemRow>('Ticket.Problem') }
    static async getLookupAsync() { return getLookupAsync<ProblemRow>('Ticket.Problem') }

    static readonly deletePermission = 'Dew:Ticket:Update';
    static readonly insertPermission = 'Dew:Ticket:Update';
    static readonly readPermission = 'Dew:Ticket:View';
    static readonly updatePermission = 'Dew:Ticket:Update';

    static readonly Fields = fieldsProxy<ProblemRow>();
}