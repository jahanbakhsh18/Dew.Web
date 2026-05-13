
namespace Dew.Ticket;

[NestedPermissionKeys]
[DisplayName("Dew")]
public class PermissionKeys
{
    [DisplayName("Ticket")]
    public class Ticket
    {
        //L2 Permission default users
        [Description("View"), ImplicitPermission(General)]
        public const string View = "Dew:Ticket:View";

        //L3 Permission For Users
        [Description("Create"), ImplicitPermission(General), ImplicitPermission(View)]
        public const string Create = "Dew:Ticket:Create";

        //L3 permission for Supervisors and Support teams...
        [Description("Update"), ImplicitPermission(View), ImplicitPermission(General)]
        public const string Update = "Dew:Ticket:Update";

        [Description("Admin"), ImplicitPermission(Update), ImplicitPermission(View), ImplicitPermission(General)]
        public const string Admin = "Dew:Ticket:Admin";
    }

    //L1
    [Description("General")]
    public const string General = "Dew:General";
}