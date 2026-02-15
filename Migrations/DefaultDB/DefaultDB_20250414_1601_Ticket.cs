using FluentMigrator;

namespace Ticketing.Migrations.DefaultDB;

[Migration(20250414_1601)]
public class DefaultDB_20250414_1601_Ticket : AutoReversingMigration
{
    public override void Up()
    {
        Create.Schema("tkt");

        Create.Table("System").InSchema("tkt")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("Name").AsString(127).NotNullable()
            .WithColumn("Description").AsString(int.MaxValue).Nullable();

        Alter.Table("Users")
            .AddColumn("SystemId").AsInt32().Nullable()
                .ForeignKey("FK_Ticket_SystemId", "tkt", "System", "Id");

        Create.Table("Priority").InSchema("tkt")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("DueTime").AsInt16().NotNullable()
            .WithColumn("Name").AsString(127).NotNullable()
            .WithColumn("Color").AsString(63).NotNullable()
            .WithColumn("Description").AsString(int.MaxValue).Nullable();

        Create.Table("Problem").InSchema("tkt")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("Name").AsString(127).NotNullable()
            .WithColumn("SystemId").AsInt32().NotNullable()
                .ForeignKey("FK_Problem_SystemId", "tkt", "System", "Id")
            .WithColumn("PriorityId").AsInt32().NotNullable()
                .ForeignKey("FK_Problem_PriorityId", "tkt", "Priority", "Id");

        Create.Table("TimeFlag").InSchema("tkt")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("Name").AsString(127).Nullable()
            .WithColumn("DuePercent").AsInt32().NotNullable()
            .WithColumn("Color").AsString(63).NotNullable()
            .WithColumn("Description").AsString(int.MaxValue).Nullable();

        Create.Table("Ticket").InSchema("tkt")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("TicketNumber").AsInt32().Nullable()
            .WithColumn("Title").AsString(127).Nullable()
            .WithColumn("Description").AsString(int.MaxValue).Nullable()
            .WithColumn("DateCreated").AsDateTime().NotNullable()
            .WithColumn("DateUpdated").AsDateTime().Nullable()
            .WithColumn("DateClosed").AsDateTime().Nullable()
            .WithColumn("SystemId").AsInt32().NotNullable()
                .ForeignKey("FK_Ticket_SystemId", "tkt", "System", "Id")
            .WithColumn("ProblemId").AsInt32().NotNullable()
                .ForeignKey("FK_Ticket_ProblemId", "tkt", "Problem", "Id")
            .WithColumn("StatusId").AsInt32().NotNullable()
                .ForeignKey("FK_Ticket_StatusId", "wf", "Status", "Id")
            .WithColumn("LastActionId").AsInt32().NotNullable()  //maybe it is not usable
                .ForeignKey("FK_Ticket_LastActionId", "wf", "Action", "Id")
            .WithColumn("TimeFlagId").AsInt32().NotNullable()
                .ForeignKey("FK_Ticket_TimeFlagId", "tkt", "TimeFlag", "Id")
            .WithColumn("FilesPath").AsString(short.MaxValue).Nullable()
            .WithColumn("CreatorUserId").AsInt32().NotNullable()
                .ForeignKey("FK_Ticket_CreatorUserId", "Users", "UserId")
            .WithColumn("ExpireDate").AsDateTime().NotNullable()
            .WithColumn("IsDeleted").AsBoolean().NotNullable().WithDefaultValue(false)
            .WithColumn("IsValid").AsBoolean().NotNullable().WithDefaultValue(false)
            .WithColumn("IsDomestic").AsBoolean().NotNullable().WithDefaultValue(true);

        Create.Table("Comment").InSchema("tkt")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("Comment").AsString(int.MaxValue).Nullable()
            .WithColumn("TicketId").AsInt32().NotNullable()
                .ForeignKey("FK_Comment_TicketId", "tkt", "Ticket", "Id")
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("FK_Comment_UserId", "Users", "UserId")
            .WithColumn("DateCreated").AsDateTime().NotNullable();

        Create.Table("Log").InSchema("tkt")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("StatusId").AsInt32().NotNullable()
                .ForeignKey("FK_Log_StatusId", "wf", "Status", "Id")
            .WithColumn("ActionId").AsInt32().NotNullable()
                .ForeignKey("FK_Log_ActionId", "wf", "Action", "Id")
            .WithColumn("TicketId").AsInt32().NotNullable()
                .ForeignKey("FK_Log_TicketId", "tkt", "Ticket", "Id")
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("FK_Log_UserId", "Users", "UserId")
            .WithColumn("DateCreated").AsDateTime().NotNullable();

        Create.Table("Message")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("Text").AsString(int.MaxValue).NotNullable()
            .WithColumn("ModuleName").AsString(31).Nullable()
            .WithColumn("DateCreated").AsDateTime().Nullable();

        Create.Table("MessageRoles")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("RoleId").AsInt32().NotNullable()
                .ForeignKey("FK_MessageRoles_RoleId", "Roles", "RoleId")
            .WithColumn("MessageId").AsInt32().NotNullable()
                .ForeignKey("FK_MessageRoles_MessageId", "Message", "Id");
    }
}