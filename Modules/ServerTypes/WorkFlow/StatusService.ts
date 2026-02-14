import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { StatusRow } from "./StatusRow";

export namespace StatusService {
    export const baseUrl = 'WorkFlow/Status';

    export declare function Create(request: SaveRequest<StatusRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<StatusRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<StatusRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<StatusRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<StatusRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<StatusRow>>;

    export const Methods = {
        Create: "WorkFlow/Status/Create",
        Update: "WorkFlow/Status/Update",
        Delete: "WorkFlow/Status/Delete",
        Retrieve: "WorkFlow/Status/Retrieve",
        List: "WorkFlow/Status/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>StatusService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}