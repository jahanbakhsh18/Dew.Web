import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { StatusRow } from "./StatusRow";

export interface StatusColumns {
    Id: Column<StatusRow>;
    Name: Column<StatusRow>;
    UpdateDate: Column<StatusRow>;
}

export class StatusColumns extends ColumnsBase<StatusRow> {
    static readonly columnsKey = 'WorkFlow.Status';
    static readonly Fields = fieldsProxy<StatusColumns>();
}