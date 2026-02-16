namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.System")]
[BasedOnRow(typeof(SystemRow), CheckNames = true)]
public class SystemColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink, Width(300)]
    public string Name { get; set; }
    [Width(400)]
    public string Description { get; set; }
}