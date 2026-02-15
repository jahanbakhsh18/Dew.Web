namespace Ticketing.Ticket;

[ConnectionKey("Default"), Module("Ticket"), TableName("[tkt].[Comment]")]
[DisplayName("Comment"), InstanceName("Comment")]
[ReadPermission("Ticketing:Ticket")]
[ModifyPermission("Ticketing:Ticket")]
[ServiceLookupPermission("Ticketing:Ticket")]
public sealed class CommentRow : Row<CommentRow.RowFields>, IIdRow, INameRow
{
    const string jTicket = nameof(jTicket);
    const string jUser = nameof(jUser);

    [DisplayName("Id"), NotNull, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Comment"), QuickSearch, NameProperty]
    public string Comment { get => fields.Comment[this]; set => fields.Comment[this] = value; }

    [DisplayName("Ticket"), NotNull, ForeignKey(typeof(TicketRow)), LeftJoin(jTicket), TextualField(nameof(TicketTitle))]
    [ServiceLookupEditor(typeof(TicketRow))]
    public int? TicketId { get => fields.TicketId[this]; set => fields.TicketId[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Date Created"), NotNull]
    public DateTime? DateCreated { get => fields.DateCreated[this]; set => fields.DateCreated[this] = value; }

    [DisplayName("Ticket Title"), Expression($"{jTicket}.[Title]")]
    public string TicketTitle { get => fields.TicketTitle[this]; set => fields.TicketTitle[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Comment;
        public Int32Field TicketId;
        public Int32Field UserId;
        public DateTimeField DateCreated;

        public StringField TicketTitle;
        public StringField Username;
    }
}