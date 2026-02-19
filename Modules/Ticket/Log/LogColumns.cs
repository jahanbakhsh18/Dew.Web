namespace Ticketing.Ticket.Columns;

[ColumnsScript("Ticket.Log")]
[BasedOnRow(typeof(LogRow), CheckNames = true)]
public class LogColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public int TicketId { get; set; }    
    public string ActionName { get; set; }
    public string StatusName { get; set; }
    public string Username { get; set; }
    public DateTime DateCreated { get; set; }
}