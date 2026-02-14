namespace WorkFlow.Columns;

[ColumnsScript("WorkFlow.Action")]
[BasedOnRow(typeof(ActionRow), CheckNames = true)]
public class ActionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink, Width(200)]
    public string Name { get; set; }
    [Width(200)]
    public DateTime UpdateDate { get; set; }
}