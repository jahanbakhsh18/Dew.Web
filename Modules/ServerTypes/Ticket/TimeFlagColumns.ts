import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TimeFlagRow } from "./TimeFlagRow";

export interface TimeFlagColumns {
    Id: Column<TimeFlagRow>;
    Name: Column<TimeFlagRow>;
    DuePercent: Column<TimeFlagRow>;
    IconName: Column<TimeFlagRow>;
    Color: Column<TimeFlagRow>;
    Description: Column<TimeFlagRow>;
}

export class TimeFlagColumns extends ColumnsBase<TimeFlagRow> {
    static readonly columnsKey = 'Ticket.TimeFlag';
    static readonly Fields = fieldsProxy<TimeFlagColumns>();
}