namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Comment")]
[BasedOnRow(typeof(CommentRow), CheckNames = true)]
public class CommentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Comment { get; set; }
    public string TicketTitle { get; set; }
    public string Username { get; set; }
    public DateTime DateCreated { get; set; }
}