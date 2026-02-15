import { fieldsProxy } from "@serenity-is/corelib";

export interface ProblemRow {
    Id?: number;
    Name?: string;
    SystemId?: number;
    PriorityId?: number;
    SystemName?: string;
    PriorityName?: string;
}

export abstract class ProblemRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Ticket.Problem';
    static readonly deletePermission = 'Ticketing:Ticket';
    static readonly insertPermission = 'Ticketing:Ticket';
    static readonly readPermission = 'Ticketing:Ticket';
    static readonly updatePermission = 'Ticketing:Ticket';

    static readonly Fields = fieldsProxy<ProblemRow>();
}