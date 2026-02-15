import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { ProblemRow } from "./ProblemRow";

export namespace ProblemService {
    export const baseUrl = 'Ticket/Problem';

    export declare function Create(request: SaveRequest<ProblemRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProblemRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProblemRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProblemRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProblemRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProblemRow>>;

    export const Methods = {
        Create: "Ticket/Problem/Create",
        Update: "Ticket/Problem/Update",
        Delete: "Ticket/Problem/Delete",
        Retrieve: "Ticket/Problem/Retrieve",
        List: "Ticket/Problem/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>ProblemService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}