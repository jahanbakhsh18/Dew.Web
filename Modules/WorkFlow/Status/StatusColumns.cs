namespace WorkFlow.Columns;

[ColumnsScript("WorkFlow.Status")]
[BasedOnRow(typeof(StatusRow), CheckNames = true)]
public class StatusColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink, Width(250)]
    public string Name { get; set; }
    public DateTime UpdateDate { get; set; }
}