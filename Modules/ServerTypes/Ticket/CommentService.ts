import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { CommentRow } from "./CommentRow";

export namespace CommentService {
    export const baseUrl = 'Ticket/Comment';

    export declare function Create(request: SaveRequest<CommentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CommentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CommentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CommentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CommentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CommentRow>>;

    export const Methods = {
        Create: "Ticket/Comment/Create",
        Update: "Ticket/Comment/Update",
        Delete: "Ticket/Comment/Delete",
        Retrieve: "Ticket/Comment/Retrieve",
        List: "Ticket/Comment/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>CommentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}