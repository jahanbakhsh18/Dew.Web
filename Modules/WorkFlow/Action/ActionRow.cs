namespace WorkFlow;

[ConnectionKey("Default"), Module("WorkFlow"), TableName("[wf].[Action]")]
[DisplayName("Action"), InstanceName("Action")]
[ReadPermission(PermissionKeys.View)]
[ModifyPermission(PermissionKeys.Modify)]
[ServiceLookupPermission(PermissionKeys.View)]
[LookupScript("WorkFlow.Action")]
public sealed class ActionRow : Row<ActionRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty, SortOrder(0)]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(63), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public DateTimeField UpdateDate;
    }
}