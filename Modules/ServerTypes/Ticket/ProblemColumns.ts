import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PriorityFormatter } from "../../Ticket/Priority/ColorPickerEditor";
import { ProblemRow } from "./ProblemRow";

export interface ProblemColumns {
    Id: Column<ProblemRow>;
    Name: Column<ProblemRow>;
    SystemName: Column<ProblemRow>;
    PriorityName: Column<ProblemRow>;
    PriorityColor: Column<ProblemRow>;
}

export class ProblemColumns extends ColumnsBase<ProblemRow> {
    static readonly columnsKey = 'Ticket.Problem';
    static readonly Fields = fieldsProxy<ProblemColumns>();
}

[PriorityFormatter]; // referenced types