import { fieldsProxy, getLookup, getLookupAsync } from "@serenity-is/corelib";

export interface ActionRow {
    Id?: number;
    Name?: string;
    UpdateDate?: string;
}

export abstract class ActionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'WorkFlow.Action';
    static readonly lookupKey = 'WorkFlow.Action';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ActionRow>('WorkFlow.Action') }
    static async getLookupAsync() { return getLookupAsync<ActionRow>('WorkFlow.Action') }

    static readonly deletePermission = 'Workflow:Modify';
    static readonly insertPermission = 'Workflow:Modify';
    static readonly readPermission = 'Workflow:View';
    static readonly updatePermission = 'Workflow:Modify';

    static readonly Fields = fieldsProxy<ActionRow>();
}