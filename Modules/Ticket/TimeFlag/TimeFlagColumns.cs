namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.TimeFlag")]
[BasedOnRow(typeof(TimeFlagRow), CheckNames = true)]
public class TimeFlagColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink, Width(400)]
    public string Name { get; set; }
    [Width(150)]
    public int DuePercent { get; set; }
    [TimeFlagFormatter]
    public string Color { get; set; }
    public string Description { get; set; }
}