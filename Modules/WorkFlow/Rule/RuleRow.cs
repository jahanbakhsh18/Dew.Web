using Ticketing.Administration;

namespace WorkFlow;

[ConnectionKey("Default"), Module("WorkFlow"), TableName("[wf].[Rule]")]
[DisplayName("Rule"), InstanceName("Rule")]
[ReadPermission(PermissionKeys.View)]
[ModifyPermission(PermissionKeys.Modify)]
public sealed class RuleRow : Row<RuleRow.RowFields>, IIdRow
{
    const string jAction = nameof(jAction);
    const string jCurrentStatus = nameof(jCurrentStatus);
    const string jNextStatus = nameof(jNextStatus);
    const string jRole = nameof(jRole);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Action"), NotNull, ForeignKey(typeof(ActionRow)), LeftJoin(jAction), TextualField(nameof(ActionName))]
    [ServiceLookupEditor(typeof(ActionRow))]
    public int? ActionId { get => fields.ActionId[this]; set => fields.ActionId[this] = value; }

    [DisplayName("Current Status"), NotNull, ForeignKey(typeof(StatusRow)), LeftJoin(jCurrentStatus)]
    [TextualField(nameof(CurrentStatusName)), ServiceLookupEditor(typeof(StatusRow))]
    public int? CurrentStatusId { get => fields.CurrentStatusId[this]; set => fields.CurrentStatusId[this] = value; }

    [DisplayName("Next Status"), NotNull, ForeignKey(typeof(StatusRow)), LeftJoin(jNextStatus), TextualField(nameof(NextStatusName))]
    [ServiceLookupEditor(typeof(StatusRow))]
    public int? NextStatusId { get => fields.NextStatusId[this]; set => fields.NextStatusId[this] = value; }

    [DisplayName("Role"), NotNull, ForeignKey(typeof(RoleRow)), LeftJoin(jRole), TextualField(nameof(RoleName))]
    [LookupEditor(typeof(RoleRow), Async = true)]
    public int? RoleId { get => fields.RoleId[this]; set => fields.RoleId[this] = value; }

    [DisplayName("Is Final State"), NotNull]
    public bool? IsFinalState { get => fields.IsFinalState[this]; set => fields.IsFinalState[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Version")]
    public int? Version { get => fields.Version[this]; set => fields.Version[this] = value; }

    [DisplayName("Action Name"), Expression($"{jAction}.[Name]")]
    public string ActionName { get => fields.ActionName[this]; set => fields.ActionName[this] = value; }

    [DisplayName("Current Status Name"), Expression($"{jCurrentStatus}.[Name]")]
    public string CurrentStatusName { get => fields.CurrentStatusName[this]; set => fields.CurrentStatusName[this] = value; }

    [DisplayName("Next Status Name"), Expression($"{jNextStatus}.[Name]")]
    public string NextStatusName { get => fields.NextStatusName[this]; set => fields.NextStatusName[this] = value; }

    [DisplayName("Role Name"), Origin(jRole, nameof(RoleRow.RoleName))]
    public string RoleName { get => fields.RoleName[this]; set => fields.RoleName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field ActionId;
        public Int32Field CurrentStatusId;
        public Int32Field NextStatusId;
        public Int32Field RoleId;
        public BooleanField IsFinalState;
        public DateTimeField UpdateDate;
        public Int32Field Version;

        public StringField ActionName;
        public StringField CurrentStatusName;
        public StringField NextStatusName;
        public StringField RoleName;
    }
}