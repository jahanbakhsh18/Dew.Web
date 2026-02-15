import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { PriorityRow } from "./PriorityRow";

export namespace PriorityService {
    export const baseUrl = 'Ticket/Priority';

    export declare function Create(request: SaveRequest<PriorityRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PriorityRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PriorityRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PriorityRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PriorityRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PriorityRow>>;

    export const Methods = {
        Create: "Ticket/Priority/Create",
        Update: "Ticket/Priority/Update",
        Delete: "Ticket/Priority/Delete",
        Retrieve: "Ticket/Priority/Retrieve",
        List: "Ticket/Priority/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>PriorityService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}