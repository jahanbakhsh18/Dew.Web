namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Comment")]
[BasedOnRow(typeof(CommentRow), CheckNames = true)]
public class CommentForm
{
    public string Comment { get; set; }
    [Hidden]
    public int TicketId { get; set; }
}