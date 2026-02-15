using FluentMigrator;

namespace Ticketing.Migrations.DefaultDB;

[Migration(20250301_1212)]
public class DefaultDB_20250301_1212_WorkFlow : AutoReversingMigration
{
    public override void Up()
    {
        Create.Schema("wf");

        Create.Table("Action").InSchema("wf")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("Name").AsString(63).NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable();

        Create.Table("Status").InSchema("wf")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("Name").AsString(63).NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable();

        Create.Table("Rule").InSchema("wf")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("ActionId").AsInt32().NotNullable()
                .ForeignKey("FK_Rule_ActionId", "wf", "Action", "Id")
            .WithColumn("CurrentStatusId").AsInt32().NotNullable()
                .ForeignKey("FK_Rule_CurrentStatusId", "wf", "Status", "Id")
            .WithColumn("NextStatusId").AsInt32().NotNullable()
                .ForeignKey("FK_Rule_NextStatusId", "wf", "Status", "Id")
            .WithColumn("RoleId").AsInt32().NotNullable()
                .ForeignKey("FK_Rule_RoleId", "Roles", "RoleId")
            .WithColumn("IsFinalState").AsBoolean().NotNullable().WithDefaultValue(false)
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("Version").AsInt32().Nullable();
    }
}