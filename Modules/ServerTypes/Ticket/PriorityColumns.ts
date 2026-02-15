import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PriorityFormatter } from "../../Ticket/Priority/ColorPickerEditor";
import { PriorityRow } from "./PriorityRow";

export interface PriorityColumns {
    Id: Column<PriorityRow>;
    Name: Column<PriorityRow>;
    Color: Column<PriorityRow>;
    DueTime: Column<PriorityRow>;
    Description: Column<PriorityRow>;
}

export class PriorityColumns extends ColumnsBase<PriorityRow> {
    static readonly columnsKey = 'Ticket.Priority';
    static readonly Fields = fieldsProxy<PriorityColumns>();
}

[PriorityFormatter]; // referenced types