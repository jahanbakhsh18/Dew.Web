import { fieldsProxy } from "@serenity-is/corelib";

export interface RuleRow {
    Id?: number;
    ActionId?: number;
    CurrentStatusId?: number;
    NextStatusId?: number;
    RoleId?: number;
    IsFinalState?: boolean;
    UpdateDate?: string;
    Version?: number;
    ActionName?: string;
    CurrentStatusName?: string;
    NextStatusName?: string;
    RoleName?: string;
}

export abstract class RuleRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'WorkFlow.Rule';
    static readonly deletePermission = 'Workflow:Modify';
    static readonly insertPermission = 'Workflow:Modify';
    static readonly readPermission = 'Workflow:View';
    static readonly updatePermission = 'Workflow:Modify';

    static readonly Fields = fieldsProxy<RuleRow>();
}