namespace WorkFlow.Columns;

[ColumnsScript("WorkFlow.Rule")]
[BasedOnRow(typeof(RuleRow), CheckNames = true)]
public class RuleColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }    
    public string CurrentStatusName { get; set; }
    public string ActionName { get; set; }
    public string NextStatusName { get; set; }
    public string RoleName { get; set; }
    [Width(100)]
    public bool IsFinalState { get; set; }
    [Width(200)]
    public DateTime UpdateDate { get; set; }
}