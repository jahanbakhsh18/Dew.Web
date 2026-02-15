namespace Ticketing.Ticket;

[ConnectionKey("Default"), Module("Ticket"), TableName("[tkt].[System]")]
[DisplayName("System"), InstanceName("System")]
[ReadPermission("Ticketing:Ticket")]
[ModifyPermission("Ticketing:Ticket")]
[ServiceLookupPermission("Ticketing:Ticket")]
public sealed class SystemRow : Row<SystemRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), NotNull, IdProperty, Identity]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(127), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;

    }
}