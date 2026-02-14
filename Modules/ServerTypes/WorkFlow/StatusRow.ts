import { fieldsProxy, getLookup, getLookupAsync } from "@serenity-is/corelib";

export interface StatusRow {
    Id?: number;
    Name?: string;
    UpdateDate?: string;
}

export abstract class StatusRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'WorkFlow.Status';
    static readonly lookupKey = 'WorkFlow.Status';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<StatusRow>('WorkFlow.Status') }
    static async getLookupAsync() { return getLookupAsync<StatusRow>('WorkFlow.Status') }

    static readonly deletePermission = 'Workflow:Modify';
    static readonly insertPermission = 'Workflow:Modify';
    static readonly readPermission = 'Workflow:View';
    static readonly updatePermission = 'Workflow:Modify';

    static readonly Fields = fieldsProxy<StatusRow>();
}