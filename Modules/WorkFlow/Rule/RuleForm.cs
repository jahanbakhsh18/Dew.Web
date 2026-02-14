namespace WorkFlow.Forms;

[FormScript("WorkFlow.Rule")]
[BasedOnRow(typeof(RuleRow), CheckNames = true)]
public class RuleForm
{
    public int RoleId { get; set; }
    public int CurrentStatusId { get; set; }
    public int ActionId { get; set; }
    public int NextStatusId { get; set; }    
    public bool IsFinalState { get; set; }
}