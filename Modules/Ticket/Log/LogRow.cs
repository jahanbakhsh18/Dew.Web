namespace Ticketing.Ticket;

[ConnectionKey("Default"), Module("Ticket"), TableName("[tkt].[Log]")]
[DisplayName("Log"), InstanceName("Log")]
[ReadPermission("Ticketing:Ticket")]
[ModifyPermission("Ticketing:Ticket")]
public sealed class LogRow : Row<LogRow.RowFields>, IIdRow
{
    const string jStatus = nameof(jStatus);
    const string jAction = nameof(jAction);
    const string jTicket = nameof(jTicket);
    const string jUser = nameof(jUser);

    [DisplayName("Id"), NotNull, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Status"), NotNull, ForeignKey(typeof(WorkFlow.StatusRow)), LeftJoin(jStatus), TextualField(nameof(StatusName))]
    [LookupEditor(typeof(WorkFlow.StatusRow), Async = true)]
    public int? StatusId { get => fields.StatusId[this]; set => fields.StatusId[this] = value; }

    [DisplayName("Action"), NotNull, ForeignKey(typeof(WorkFlow.ActionRow)), LeftJoin(jAction), TextualField(nameof(ActionName))]
    [LookupEditor(typeof(WorkFlow.ActionRow), Async = true)]
    public int? ActionId { get => fields.ActionId[this]; set => fields.ActionId[this] = value; }

    [DisplayName("Ticket Id"), NotNull, ForeignKey(typeof(TicketRow)), LeftJoin(jTicket), TextualField(nameof(TicketTitle))]
    [ServiceLookupEditor(typeof(TicketRow))]
    public int? TicketId { get => fields.TicketId[this]; set => fields.TicketId[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Date Created"), NotNull]
    public DateTime? DateCreated { get => fields.DateCreated[this]; set => fields.DateCreated[this] = value; }

    [DisplayName("Status Name"), Expression($"{jStatus}.[Name]")]
    public string StatusName { get => fields.StatusName[this]; set => fields.StatusName[this] = value; }

    [DisplayName("Action Name"), Expression($"{jAction}.[Name]")]
    public string ActionName { get => fields.ActionName[this]; set => fields.ActionName[this] = value; }

    [DisplayName("Ticket Title"), Expression($"{jTicket}.[Title]")]
    public string TicketTitle { get => fields.TicketTitle[this]; set => fields.TicketTitle[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field StatusId;
        public Int32Field ActionId;
        public Int32Field TicketId;
        public Int32Field UserId;
        public DateTimeField DateCreated;

        public StringField StatusName;
        public StringField ActionName;
        public StringField TicketTitle;
        public StringField Username;
    }
}