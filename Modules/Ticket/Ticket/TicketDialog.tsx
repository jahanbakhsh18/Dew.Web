import { EntityDialog, TabsExtensions, WidgetProps } from '@serenity-is/corelib';
import { TicketForm, TicketRow, TicketService } from '../../ServerTypes/Ticket';
import { LogGrid } from '../Log/LogGrid';
import { DialogUtils } from '@serenity-is/extensions';
import { TicketDbTexts } from '../../ServerTypes/Texts';

export class TicketDialog<P = {}> extends EntityDialog<TicketRow, P> {
    static override[Symbol.typeInfo] = this.registerClass("Ticketing.Ticket.");

    protected override getFormKey() { return TicketForm.formKey; }
    protected override getRowDefinition() { return TicketRow; }
    protected override getService() { return TicketService.baseUrl; }

    protected form = new TicketForm(this.idPrefix);

    declare private logsGrid: LogGrid;
    declare private loadedState: string;

    constructor(props: WidgetProps<P>) {
        super(props);
    }

    override initDialog() {
        super.initDialog();
        DialogUtils.pendingChangesConfirmation(this.domNode, () => this.getSaveState() != this.loadedState);
    }

    getSaveState() {
        try {
            return JSON.stringify(this.getSaveEntity());
        }
        catch (e) {
            return null;
        }
    }

    protected override loadResponse(data: any) {
        super.loadResponse(data);
        this.loadedState = this.getSaveState();
    }

    protected override loadEntity(entity: TicketRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'Logs', this.isNewOrDeleted());
        this.logsGrid.TicketId = entity.Id;
    }

    protected override renderContents(): any {
        const id = this.useIdPrefix();
        return (
            <div id={id.Tabs} class="s-DialogContent">
                <ul>
                    <li><a href={'#' + id.TabTicket}><span> {TicketDbTexts.Ticket.EntitySingular} </span></a></li>
                    <li><a href={'#' + id.TabLogs}><span> {TicketDbTexts.Log.EntityPlural} </span></a></li>
                </ul>
                <div id={id.TabTicket} class="tab-pane s-TabTicket">
                    <div id={id.Toolbar} class="s-DialogToolbar">
                    </div>
                    <form id={id.Form} action="" class="s-Form">
                        <div id={id.PropertyGrid}></div>
                    </form>
                </div>
                <div id={id.TabLogs} class="tab-pane s-TabLogs">
                    <LogGrid id={id.LogsGrid} ref={grid => {
                        this.logsGrid = grid;
                        this.logsGrid.openDialogsAsPanel = false;
                    }} />
                </div>
            </div>
        )
    }

    protected override afterLoadEntity() {
        super.afterLoadEntity();
        this.form.CommentList.ticketId = this.entityId;
    }
}