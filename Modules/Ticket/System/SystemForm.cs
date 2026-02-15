namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.System")]
[BasedOnRow(typeof(SystemRow), CheckNames = true)]
public class SystemForm
{
    public string Name { get; set; }
    public string Description { get; set; }
}