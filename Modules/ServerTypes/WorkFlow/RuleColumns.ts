import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { RuleRow } from "./RuleRow";

export interface RuleColumns {
    Id: Column<RuleRow>;
    CurrentStatusName: Column<RuleRow>;
    ActionName: Column<RuleRow>;
    NextStatusName: Column<RuleRow>;
    RoleName: Column<RuleRow>;
    IsFinalState: Column<RuleRow>;
    UpdateDate: Column<RuleRow>;
}

export class RuleColumns extends ColumnsBase<RuleRow> {
    static readonly columnsKey = 'WorkFlow.Rule';
    static readonly Fields = fieldsProxy<RuleColumns>();
}