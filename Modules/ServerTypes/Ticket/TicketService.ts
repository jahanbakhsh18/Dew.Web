import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { TicketRow } from "./TicketRow";

export namespace TicketService {
    export const baseUrl = 'Ticket/Ticket';

    export declare function Create(request: SaveRequest<TicketRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<TicketRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TicketRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<TicketRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TicketRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<TicketRow>>;

    export const Methods = {
        Create: "Ticket/Ticket/Create",
        Update: "Ticket/Ticket/Update",
        Delete: "Ticket/Ticket/Delete",
        Retrieve: "Ticket/Ticket/Retrieve",
        List: "Ticket/Ticket/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>TicketService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}