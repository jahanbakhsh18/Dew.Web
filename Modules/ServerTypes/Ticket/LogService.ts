import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { LogRow } from "./LogRow";

export namespace LogService {
    export const baseUrl = 'Ticket/Log';

    export declare function Create(request: SaveRequest<LogRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<LogRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<LogRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<LogRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<LogRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<LogRow>>;

    export const Methods = {
        Create: "Ticket/Log/Create",
        Update: "Ticket/Log/Update",
        Delete: "Ticket/Log/Delete",
        Retrieve: "Ticket/Log/Retrieve",
        List: "Ticket/Log/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>LogService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}