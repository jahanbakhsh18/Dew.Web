namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.System")]
[BasedOnRow(typeof(SystemRow), CheckNames = true)]
public class SystemColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
}