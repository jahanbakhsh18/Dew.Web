import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { LogRow } from "./LogRow";

export interface LogColumns {
    Id: Column<LogRow>;
    StatusName: Column<LogRow>;
    ActionName: Column<LogRow>;
    TicketTitle: Column<LogRow>;
    Username: Column<LogRow>;
    DateCreated: Column<LogRow>;
}

export class LogColumns extends ColumnsBase<LogRow> {
    static readonly columnsKey = 'Ticket.Log';
    static readonly Fields = fieldsProxy<LogColumns>();
}