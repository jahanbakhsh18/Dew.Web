namespace WorkFlow.Forms;

[FormScript("WorkFlow.Action")]
[BasedOnRow(typeof(ActionRow), CheckNames = true)]
public class ActionForm
{
    public string Name { get; set; }
}