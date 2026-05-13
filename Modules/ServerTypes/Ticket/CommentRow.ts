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
    static readonly deletePermission = 'Dew:Ticket';
    static readonly insertPermission = 'Dew:Ticket';
    static readonly readPermission = 'Dew:Ticket';
    static readonly updatePermission = 'Dew:Ticket';

    static readonly Fields = fieldsProxy<CommentRow>();
}