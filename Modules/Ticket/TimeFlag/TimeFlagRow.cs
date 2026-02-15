namespace Ticketing.Ticket;

[ConnectionKey("Default"), Module("Ticket"), TableName("[tkt].[TimeFlag]")]
[DisplayName("Time Flag"), InstanceName("Time Flag")]
[ReadPermission("Ticketing:Ticket")]
[ModifyPermission("Ticketing:Ticket")]
[ServiceLookupPermission("Ticketing:Ticket")]
public sealed class TimeFlagRow : Row<TimeFlagRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), NotNull, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(127), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Due Percent"), NotNull]
    public int? DuePercent { get => fields.DuePercent[this]; set => fields.DuePercent[this] = value; }

    [DisplayName("Icon Name"), Size(63)]
    public string IconName { get => fields.IconName[this]; set => fields.IconName[this] = value; }

    [DisplayName("Color"), Size(63), NotNull]
    public string Color { get => fields.Color[this]; set => fields.Color[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public Int32Field DuePercent;
        public StringField IconName;
        public StringField Color;
        public StringField Description;

    }
}