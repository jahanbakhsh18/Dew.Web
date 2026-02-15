namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Problem")]
[BasedOnRow(typeof(ProblemRow), CheckNames = true)]
public class ProblemColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string SystemName { get; set; }
    public string PriorityName { get; set; }
}