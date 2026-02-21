import { toId } from "@serenity-is/corelib";
import { GridEditorBase } from "@serenity-is/extensions";
import { CommentColumns, CommentRow, CommentService } from "../../ServerTypes/Ticket";
import { CommentDialog } from "./CommentDialog";
import { TicketNS } from "../../ServerTypes/Namespaces";

export class CommentListEditor<P = {}> extends GridEditorBase<CommentRow, P> {
    static override[Symbol.typeInfo] = this.registerEditor(TicketNS);

    protected override getColumnsKey() { return CommentColumns.columnsKey; }
    protected override getDialogType() { return CommentDialog; }
    protected override getRowDefinition() { return CommentRow; }
    protected override getService() { return CommentService.baseUrl; }

    protected override getGridCanLoad() {
        return super.getGridCanLoad() && this.ticketId != null;
    }

    protected override getNewEntity() {
        return {            
            TicketId: this.ticketId
        };
    }

    declare private _ticketId: number;

    public get ticketId() {
        return this._ticketId;
    }

    public set ticketId(value: number) {
        if (this._ticketId !== toId(value)) {
            this.setEquality(CommentRow.Fields.TicketId, this._ticketId = toId(value));
            this.connectedMode = this._ticketId != null;
            this.refresh();
        }
    }
}
