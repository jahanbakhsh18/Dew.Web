
namespace WorkFlow;

[NestedPermissionKeys]
[DisplayName("Workflow")]
public class PermissionKeys
{
    public const string View = "Workflow:View";

    [Description("Create/Update"), ImplicitPermission(View)]
    public const string Modify = "Workflow:Modify";
}