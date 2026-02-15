namespace Ticketing.Ticket;

[ConnectionKey("Default"), Module("Ticket"), TableName("[tkt].[Priority]")]
[DisplayName("Priority"), InstanceName("Priority")]
[ReadPermission("Ticketing:Ticket")]
[ModifyPermission("Ticketing:Ticket")]
[ServiceLookupPermission("Ticketing:Ticket")]
public sealed class PriorityRow : Row<PriorityRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), NotNull, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Due Time"), NotNull]
    public short? DueTime { get => fields.DueTime[this]; set => fields.DueTime[this] = value; }

    [DisplayName("Name"), Size(127), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Icon Name"), Size(63)]
    public string IconName { get => fields.IconName[this]; set => fields.IconName[this] = value; }

    [DisplayName("Color"), Size(63), NotNull]
    public string Color { get => fields.Color[this]; set => fields.Color[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int16Field DueTime;
        public StringField Name;
        public StringField IconName;
        public StringField Color;
        public StringField Description;

    }
}