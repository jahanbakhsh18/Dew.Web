namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Priority")]
[BasedOnRow(typeof(PriorityRow), CheckNames = true)]
public class PriorityForm
{
    public string Name { get; set; }
    [ColorPickerEditor]
    public string Color { get; set; }
    public string Description { get; set; }
    public short DueTime { get; set; }
}