namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.TimeFlag")]
[BasedOnRow(typeof(TimeFlagRow), CheckNames = true)]
public class TimeFlagForm
{
    public string Name { get; set; }
    public int DuePercent { get; set; }
    [ColorPickerEditor]
    public string Color { get; set; }
    public string Description { get; set; }
}