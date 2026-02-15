import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { SystemRow } from "./SystemRow";

export namespace SystemService {
    export const baseUrl = 'Ticket/System';

    export declare function Create(request: SaveRequest<SystemRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SystemRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SystemRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SystemRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SystemRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SystemRow>>;

    export const Methods = {
        Create: "Ticket/System/Create",
        Update: "Ticket/System/Update",
        Delete: "Ticket/System/Delete",
        Retrieve: "Ticket/System/Retrieve",
        List: "Ticket/System/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>SystemService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}