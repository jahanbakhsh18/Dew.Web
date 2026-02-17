
namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Ticket")]
[BasedOnRow(typeof(TicketRow), CheckNames = true)]
public class TicketColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [QuickFilter]
    public string SystemName { get; set; }
    [QuickFilter]
    [QuickFilterOption("CascadeFrom", "SystemId"), QuickFilterOption("CascadeField", "SystemId")]
    public string ProblemName { get; set; }
    [Width(150)]
    public string CreatorUsername { get; set; }
    [Width(150), SortOrder(1, true)]
    public DateTime DateCreated { get; set; }
    [Width(150)]
    public DateTime ExpireDate { get; set; }
    [Width(100), TimeFlagFormatter]
    public String TimeFlagColor { get; set; }
    [Width(150), QuickFilter]
    public String StatusName { get; set; }
    [Width(150)]
    public DateTime DateClosed { get; set; }
}