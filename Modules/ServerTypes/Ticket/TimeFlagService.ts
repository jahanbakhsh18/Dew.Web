import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { TimeFlagRow } from "./TimeFlagRow";

export namespace TimeFlagService {
    export const baseUrl = 'Ticket/TimeFlag';

    export declare function Create(request: SaveRequest<TimeFlagRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<TimeFlagRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TimeFlagRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<TimeFlagRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TimeFlagRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<TimeFlagRow>>;

    export const Methods = {
        Create: "Ticket/TimeFlag/Create",
        Update: "Ticket/TimeFlag/Update",
        Delete: "Ticket/TimeFlag/Delete",
        Retrieve: "Ticket/TimeFlag/Retrieve",
        List: "Ticket/TimeFlag/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>TimeFlagService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}