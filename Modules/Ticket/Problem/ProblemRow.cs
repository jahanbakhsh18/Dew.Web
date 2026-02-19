namespace Ticketing.Ticket;

[ConnectionKey("Default"), Module("Ticket"), TableName("[tkt].[Problem]")]
[DisplayName("Problem"), InstanceName("Problem")]
[ReadPermission(PermissionKeys.Ticket.View)]
[ModifyPermission(PermissionKeys.Ticket.Update)]
[ServiceLookupPermission("Ticketing:Ticket")]
[LookupScript]
public sealed class ProblemRow : Row<ProblemRow.RowFields>, IIdRow, INameRow
{
    const string jSystem = nameof(jSystem);
    const string jPriority = nameof(jPriority);

    [DisplayName("Id"), NotNull, IdProperty, Identity]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(127), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("System"), NotNull, ForeignKey(typeof(SystemRow)), LeftJoin(jSystem), TextualField(nameof(SystemName))]
    [LookupEditor(typeof(SystemRow)), LookupInclude]
    public int? SystemId { get => fields.SystemId[this]; set => fields.SystemId[this] = value; }

    [DisplayName("Priority"), NotNull, ForeignKey(typeof(PriorityRow)), LeftJoin(jPriority), TextualField(nameof(PriorityName))]
    [LookupEditor(typeof(PriorityRow))]
    public int? PriorityId { get => fields.PriorityId[this]; set => fields.PriorityId[this] = value; }

    [DisplayName("System Name"), Expression($"{jSystem}.[Name]"), LookupInclude]
    public string SystemName { get => fields.SystemName[this]; set => fields.SystemName[this] = value; }

    [DisplayName("Priority Name"), Expression($"{jPriority}.[Name]")]
    public string PriorityName { get => fields.PriorityName[this]; set => fields.PriorityName[this] = value; }
    
    [DisplayName("Color"), Expression($"{jPriority}.[Color]")]
    public string PriorityColor { get => fields.PriorityColor[this]; set => fields.PriorityColor[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public Int32Field SystemId;
        public Int32Field PriorityId;

        public StringField SystemName;
        public StringField PriorityName;
        public StringField PriorityColor;
    }
}