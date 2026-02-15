import { fieldsProxy } from "@serenity-is/corelib";

export interface CommentRow {
    Id?: number;
    Comment?: string;
    TicketId?: number;
    UserId?: number;
    DateCreated?: string;
    TicketTitle?: string;
    Username?: string;
}

export abstract class CommentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Comment';
    static readonly localTextPrefix = 'Ticket.Comment';
    static readonly deletePermission = 'Ticketing:Ticket';
    static readonly insertPermission = 'Ticketing:Ticket';
    static readonly readPermission = 'Ticketing:Ticket';
    static readonly updatePermission = 'Ticketing:Ticket';

    static readonly Fields = fieldsProxy<CommentRow>();
}