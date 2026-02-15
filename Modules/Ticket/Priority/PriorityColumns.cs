namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Priority")]
[BasedOnRow(typeof(PriorityRow), CheckNames = true)]
public class PriorityColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }    
    [EditLink]
    public string Name { get; set; }
    [PriorityFormatter]
    public string Color { get; set; }
    [Width(200)]
    public short DueTime { get; set; }
    public string Description { get; set; }
}