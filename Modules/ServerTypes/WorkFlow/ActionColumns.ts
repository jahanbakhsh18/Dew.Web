import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ActionRow } from "./ActionRow";

export interface ActionColumns {
    Id: Column<ActionRow>;
    Name: Column<ActionRow>;
    UpdateDate: Column<ActionRow>;
}

export class ActionColumns extends ColumnsBase<ActionRow> {
    static readonly columnsKey = 'WorkFlow.Action';
    static readonly Fields = fieldsProxy<ActionColumns>();
}