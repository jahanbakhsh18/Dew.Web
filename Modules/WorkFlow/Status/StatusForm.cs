namespace WorkFlow.Forms;

[FormScript("WorkFlow.Status")]
[BasedOnRow(typeof(StatusRow), CheckNames = true)]
public class StatusForm
{
    public string Name { get; set; }
}