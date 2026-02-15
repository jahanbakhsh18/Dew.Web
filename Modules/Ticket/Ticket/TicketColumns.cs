using System.IO;

namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Ticket")]
[BasedOnRow(typeof(TicketRow), CheckNames = true)]
public class TicketColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public int TicketNumber { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime DateClosed { get; set; }
    public string SystemName { get; set; }
    public string ProblemName { get; set; }
    public string StatusName { get; set; }
    public string LastActionName { get; set; }
    public string TimeFlagName { get; set; }
    public string FilesPath { get; set; }
    public string CreatorUserUsername { get; set; }
    public DateTime ExpireDate { get; set; }
    public Stream IsDeleted { get; set; }
    public Stream IsValid { get; set; }
    public Stream IsDomestic { get; set; }
}