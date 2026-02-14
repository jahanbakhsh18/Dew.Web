import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { RuleRow } from "./RuleRow";

export namespace RuleService {
    export const baseUrl = 'WorkFlow/Rule';

    export declare function Create(request: SaveRequest<RuleRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<RuleRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<RuleRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<RuleRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<RuleRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<RuleRow>>;

    export const Methods = {
        Create: "WorkFlow/Rule/Create",
        Update: "WorkFlow/Rule/Update",
        Delete: "WorkFlow/Rule/Delete",
        Retrieve: "WorkFlow/Rule/Retrieve",
        List: "WorkFlow/Rule/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>RuleService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}