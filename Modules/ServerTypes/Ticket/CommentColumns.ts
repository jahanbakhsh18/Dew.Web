import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CommentRow } from "./CommentRow";

export interface CommentColumns {
    Id: Column<CommentRow>;
    Comment: Column<CommentRow>;
    TicketTitle: Column<CommentRow>;
    Username: Column<CommentRow>;
    DateCreated: Column<CommentRow>;
}

export class CommentColumns extends ColumnsBase<CommentRow> {
    static readonly columnsKey = 'Ticket.Comment';
    static readonly Fields = fieldsProxy<CommentColumns>();
}