import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TimeFlagFormatter } from "../../Ticket/Priority/ColorPickerEditor";
import { TicketRow } from "./TicketRow";

export interface TicketColumns {
    Id: Column<TicketRow>;
    StatusName: Column<TicketRow>;
    SystemName: Column<TicketRow>;
    ProblemName: Column<TicketRow>;
    CreatorUsername: Column<TicketRow>;
    DateCreated: Column<TicketRow>;
    ExpireDate: Column<TicketRow>;
    TimeFlagColor: Column<TicketRow>;
    DateClosed: Column<TicketRow>;
}

export class TicketColumns extends ColumnsBase<TicketRow> {
    static readonly columnsKey = 'Ticket.Ticket';
    static readonly Fields = fieldsProxy<TicketColumns>();
}

[TimeFlagFormatter]; // referenced types