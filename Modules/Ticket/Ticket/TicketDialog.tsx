import { EntityDialog, TabsExtensions, WidgetProps, Authorization } from '@serenity-is/corelib';
import { AvailableAction, TicketForm, TicketRow, TicketService } from '../../ServerTypes/Ticket';
import { LogGrid } from '../Log/LogGrid';
import { DialogUtils } from '@serenity-is/extensions';
import { TicketDbTexts } from '../../ServerTypes/Texts';

export class TicketDialog<P = {}> extends EntityDialog<TicketRow, P> {
    static override[Symbol.typeInfo] = this.registerClass("Dew.Ticket.");

    protected override getFormKey() { return TicketForm.formKey; }
    protected override getRowDefinition() { return TicketRow; }
    protected override getService() { return TicketService.baseUrl; }

    protected form = new TicketForm(this.idPrefix);

    declare private logsGrid: LogGrid;
    declare private loadedState: string;

    constructor(props: WidgetProps<P>) {
        super(props);

        if (!this.isNew())
            this.form.LastActionId.getGridField().toggle(false);
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

    protected override getSaveEntity() {
        const entity = super.getSaveEntity();
        if (entity) {
            delete (entity as any).AvailableActions;
        }
        return entity;
    }

    protected override loadResponse(data: any) {
        super.loadResponse(data);
        this.loadedState = this.getSaveState() ?? '';
    }

    protected override loadEntity(entity: TicketRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'Logs', this.isNewOrDeleted());

        if (this.logsGrid) {
            this.logsGrid.TicketId = entity.Id ?? 0;
            this.logsGrid.set_readOnly?.(true) ?? (this.logsGrid.readOnly = true);
        }
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
                    <form id={id.Form} action="" class="s-Form">
                        <div id={id.PropertyGrid}></div>
                    </form>
                    <div id={id.Toolbar} class="s-DialogToolbar"></div>
                </div>
                <div id={id.TabLogs} class="tab-pane s-TabLogs">
                    <LogGrid id={id.LogsGrid} ref={grid => {
                        this.logsGrid = grid;
                        if (this.logsGrid) {
                            this.logsGrid.openDialogsAsPanel = false;
                            if (this.entity) {
                                this.logsGrid.set_readOnly?.(true) ?? (this.logsGrid.readOnly = true);
                            }
                        }
                    }} />
                </div>
            </div>
        )
    }

    protected override afterLoadEntity() {
        super.afterLoadEntity();
        this.form.CommentList.ticketId = this.entityId;

        this.toolbar.element.findFirst('.save-and-close-button').hide();
        this.toolbar.element.findFirst('.delete-button').hide();
        this.toolbar.element.findFirst('.apply-changes-button').hide();

        if (!this.isNew()) {
            this.form.SystemId.set_readOnly(true);
            this.form.ProblemId.set_readOnly(true);
            this.form.Description.element.attr('readonly', 'readonly');
        }
        else {
            this.form.StatusId.set_value("1");      //Creating
            this.form.LastActionId.set_value("1");  //Create Ticket
        }

        this.form.StatusId.set_readOnly(true);
        this.form.LastActionId.set_readOnly(true);

        this.buildToolbar();
    }

    private buildToolbar() {
        const toolbar = this.toolbar?.element;
        if (!toolbar) return;

        const ul = document.createElement('ul');
        ul.style.listStyle = 'none';
        ul.style.padding = '0';
        ul.style.margin = '0';
        ul.style.display = 'flex';
        ul.style.gap = '8px';
        ul.style.justifyContent = 'center';
        ul.style.alignItems = 'center';

        // Add workflow action buttons
        const actions = this.entity.AvailableActions as AvailableAction[];
        if (actions && actions.length > 0) {
            for (const action of actions) {
                const li = document.createElement('li');
                const button = document.createElement('button');
                button.type = 'button';
                button.className = 'btn btn-primary s-Button';
                button.textContent = action.Name ?? 'Action';
                button.addEventListener('click', () => this.applyAction(action.ActionId));
                li.appendChild(button);
                ul.appendChild(li);
            }
        }

        if (!this.isNew() && Authorization.hasPermission(TicketRow.deletePermission)) {
            const li = document.createElement('li');
            const btnDelete = document.createElement('button');
            btnDelete.type = 'button';
            btnDelete.className = 'btn btn-danger s-Button';
            btnDelete.textContent = 'Delete';
            btnDelete.addEventListener('click', () => this.deleteButton.click());
            li.appendChild(btnDelete);
            ul.appendChild(li);
        }

        if (this.isNew() && Authorization.hasPermission(TicketRow.insertPermission)) {
            const li = document.createElement('li');
            const btnDelete = document.createElement('button');
            btnDelete.type = 'button';
            btnDelete.className = 'btn btn-success s-Button';
            btnDelete.textContent = 'Create';
            btnDelete.addEventListener('click', () => this.saveAndCloseButton.click());
            li.appendChild(btnDelete);
            ul.appendChild(li);
        }

        toolbar.append(ul);
    }

    private applyAction(actionId: number | undefined) {
        if (actionId != undefined && actionId > 0) {
            this.form.LastActionId.value = actionId.toString();
            this.saveAndCloseButton.click();
        }
    }
}