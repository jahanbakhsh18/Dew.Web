namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Problem")]
[BasedOnRow(typeof(ProblemRow), CheckNames = true)]
public class ProblemForm
{
    public string Name { get; set; }
    public int SystemId { get; set; }
    public int PriorityId { get; set; }
}