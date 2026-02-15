import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SystemRow } from "./SystemRow";

export interface SystemColumns {
    Id: Column<SystemRow>;
    Name: Column<SystemRow>;
    Description: Column<SystemRow>;
}

export class SystemColumns extends ColumnsBase<SystemRow> {
    static readonly columnsKey = 'Ticket.System';
    static readonly Fields = fieldsProxy<SystemColumns>();
}