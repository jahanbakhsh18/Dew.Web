import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { ActionRow } from "./ActionRow";

export namespace ActionService {
    export const baseUrl = 'WorkFlow/Action';

    export declare function Create(request: SaveRequest<ActionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ActionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ActionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ActionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ActionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ActionRow>>;

    export const Methods = {
        Create: "WorkFlow/Action/Create",
        Update: "WorkFlow/Action/Update",
        Delete: "WorkFlow/Action/Delete",
        Retrieve: "WorkFlow/Action/Retrieve",
        List: "WorkFlow/Action/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>ActionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}