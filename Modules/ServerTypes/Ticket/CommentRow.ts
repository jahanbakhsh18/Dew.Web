import { fieldsProxy } from "@serenity-is/corelib";

export interface CommentRow {
    Id?: number;
    Comment?: string;
    TicketId?: number;
    UserId?: number;
    DateCreated?: string;
    Username?: string;
}

export abstract class CommentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Comment';
    static readonly localTextPrefix = 'Ticket.Comment';
    static readonly deletePermission = 'Dew:Ticket:Update';
    static readonly insertPermission = 'Dew:Ticket:Update';
    static readonly readPermission = 'Dew:Ticket:View';
    static readonly updatePermission = 'Dew:Ticket:Update';

    static readonly Fields = fieldsProxy<CommentRow>();
}