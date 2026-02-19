namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Comment")]
[BasedOnRow(typeof(CommentRow), CheckNames = true)]
public class CommentColumns
{
    [EditLink, Width(250)]
    public string Comment { get; set; }
    [Width(125)]
    public string Username { get; set; }
    [Width(125)]
    public DateTime DateCreated { get; set; }
}