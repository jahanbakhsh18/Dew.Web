namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Comment")]
[BasedOnRow(typeof(CommentRow), CheckNames = true)]
public class CommentForm
{
    [Hidden]
    public int Id { get; set; }
    public string Comment { get; set; }
}