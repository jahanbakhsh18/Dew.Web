namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Priority")]
[BasedOnRow(typeof(PriorityRow), CheckNames = true)]
public class PriorityColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public short DueTime { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string IconName { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }
}