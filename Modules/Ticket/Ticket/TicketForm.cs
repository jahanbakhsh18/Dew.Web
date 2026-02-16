using System.IO;

namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Ticket")]
[BasedOnRow(typeof(TicketRow), CheckNames = true)]
public class TicketForm
{
    [Width(200)]
    public int SystemId { get; set; }
    [Width(500)]
    public int ProblemId { get; set; }    
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    public int StatusId { get; set; }
    public int LastActionId { get; set; }    
    //public string FilesPath { get; set; }
}