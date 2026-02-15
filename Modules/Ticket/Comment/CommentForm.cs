namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Comment")]
[BasedOnRow(typeof(CommentRow), CheckNames = true)]
public class CommentForm
{
    public string Comment { get; set; }
    public int TicketId { get; set; }
    public int UserId { get; set; }
    public DateTime DateCreated { get; set; }
}