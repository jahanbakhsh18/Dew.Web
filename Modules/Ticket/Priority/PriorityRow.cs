namespace Ticketing.Ticket;

[ConnectionKey("Default"), Module("Ticket"), TableName("[tkt].[Priority]")]
[DisplayName("Priority"), InstanceName("Priority")]
[ReadPermission(PermissionKeys.Ticket.View)]
[UpdatePermission(PermissionKeys.Ticket.Admin)]
[InsertPermission(PermissionKeys.Ticket.Admin)]
[ServiceLookupPermission("Ticketing:Ticket")]
[LookupScript("Ticketing.Priority")]
public sealed class PriorityRow : Row<PriorityRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), NotNull, Identity, IdProperty, SortOrder(1, false)]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Due Time"), NotNull]
    public short? DueTime { get => fields.DueTime[this]; set => fields.DueTime[this] = value; }

    [DisplayName("Name"), Size(127), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Color"), Size(63), NotNull]
    public string Color { get => fields.Color[this]; set => fields.Color[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int16Field DueTime;
        public StringField Name;
        public StringField Color;
        public StringField Description;

    }
}