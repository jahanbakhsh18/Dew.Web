import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TicketRow } from "./TicketRow";

export interface TicketColumns {
    Id: Column<TicketRow>;
    TicketNumber: Column<TicketRow>;
    Title: Column<TicketRow>;
    Description: Column<TicketRow>;
    DateCreated: Column<TicketRow>;
    DateUpdated: Column<TicketRow>;
    DateClosed: Column<TicketRow>;
    SystemName: Column<TicketRow>;
    ProblemName: Column<TicketRow>;
    StatusName: Column<TicketRow>;
    LastActionName: Column<TicketRow>;
    TimeFlagName: Column<TicketRow>;
    FilesPath: Column<TicketRow>;
    CreatorUserUsername: Column<TicketRow>;
    ExpireDate: Column<TicketRow>;
}

export class TicketColumns extends ColumnsBase<TicketRow> {
    static readonly columnsKey = 'Ticket.Ticket';
    static readonly Fields = fieldsProxy<TicketColumns>();
}