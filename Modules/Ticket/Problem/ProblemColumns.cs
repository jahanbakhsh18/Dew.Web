namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Problem")]
[BasedOnRow(typeof(ProblemRow), CheckNames = true)]
public class ProblemColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, SortOrder(1, false)]
    public int Id { get; set; }
    [EditLink, Width(500)]
    public string Name { get; set; }
    [Width(200), QuickFilter]
    public string SystemName { get; set; }
    [Width(200), QuickFilter]
    public string PriorityName { get; set; }
    [PriorityFormatter]
    public string PriorityColor { get; set; }
}