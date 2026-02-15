namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.TimeFlag")]
[BasedOnRow(typeof(TimeFlagRow), CheckNames = true)]
public class TimeFlagColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public int DuePercent { get; set; }
    public string IconName { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }
}