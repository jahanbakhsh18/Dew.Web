using System.IO;

namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Ticket")]
[BasedOnRow(typeof(TicketRow), CheckNames = true)]
public class TicketForm
{
    public int TicketNumber { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime DateClosed { get; set; }
    public int SystemId { get; set; }
    public int ProblemId { get; set; }
    public int StatusId { get; set; }
    public int LastActionId { get; set; }
    public int TimeFlagId { get; set; }
    public string FilesPath { get; set; }
    public int CreatorUserId { get; set; }
    public DateTime ExpireDate { get; set; }
    public Stream IsDeleted { get; set; }
    public Stream IsValid { get; set; }
    public Stream IsDomestic { get; set; }
}