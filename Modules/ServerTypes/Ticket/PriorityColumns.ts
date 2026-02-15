import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PriorityRow } from "./PriorityRow";

export interface PriorityColumns {
    Id: Column<PriorityRow>;
    DueTime: Column<PriorityRow>;
    Name: Column<PriorityRow>;
    IconName: Column<PriorityRow>;
    Color: Column<PriorityRow>;
    Description: Column<PriorityRow>;
}

export class PriorityColumns extends ColumnsBase<PriorityRow> {
    static readonly columnsKey = 'Ticket.Priority';
    static readonly Fields = fieldsProxy<PriorityColumns>();
}