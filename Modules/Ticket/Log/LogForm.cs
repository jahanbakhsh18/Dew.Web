namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Log")]
[BasedOnRow(typeof(LogRow), CheckNames = true)]
public class LogForm
{
    public int StatusId { get; set; }
    public int ActionId { get; set; }
    public int TicketId { get; set; }
    public int UserId { get; set; }
    public DateTime DateCreated { get; set; }
}