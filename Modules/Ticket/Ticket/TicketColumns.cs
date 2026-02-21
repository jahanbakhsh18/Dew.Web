namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Ticket")]
[BasedOnRow(typeof(TicketRow), CheckNames = true)]
public class TicketColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(50)]
    public int Id { get; set; }
    [Width(100), QuickFilter, EditLink]
    public string StatusName { get; set; }
    [Width(75), TimeFlagFormatter]
    public string TimeFlagColor { get; set; }

    [QuickFilter, Width(200)]
    public string SystemName { get; set; }
    [QuickFilter, Width(400)]
    [QuickFilterOption("CascadeFrom", "SystemId"), QuickFilterOption("CascadeField", "SystemId")]
    public string ProblemName { get; set; }
    [Width(150)]
    public string CreatorUsername { get; set; }
    [Width(125), SortOrder(1, true)]
    public DateTime DateCreated { get; set; }
    [Width(125)]
    public DateTime ExpireDate { get; set; }
    [Width(125)]
    public DateTime DateClosed { get; set; }
}