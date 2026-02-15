namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Priority")]
[BasedOnRow(typeof(PriorityRow), CheckNames = true)]
public class PriorityForm
{
    public short DueTime { get; set; }
    public string Name { get; set; }
    public string IconName { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }
}