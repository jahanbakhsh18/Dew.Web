using FluentMigrator;

namespace Ticketing.Migrations.DefaultDB;

[Migration(20240101_1118)]
public class DefaultDB_20240101_1118_Initial : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Country")
            .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().IdentityKey(this)
            .WithColumn("Name").AsString(31).NotNullable();

        Create.Table("Users")
            .WithColumn("UserId").AsInt32().IdentityKey(this)
            .WithColumn("Username").AsString(100).NotNullable().Unique("IX_Users_Username")
            .WithColumn("DisplayName").AsString(100).NotNullable()
            .WithColumn("Phone").AsString(16).Nullable()
            .WithColumn("Email").AsString(100).Nullable()
            .WithColumn("Source").AsString(4).NotNullable()
            .WithColumn("PasswordHash").AsString(86).NotNullable()
            .WithColumn("PasswordSalt").AsString(10).NotNullable()
            .WithColumn("LastDirectoryUpdate").AsDateTime().Nullable()
            .WithColumn("UserImage").AsString(100).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1)
            .WithColumn("CountryId").AsInt32().Nullable()
                .ForeignKey("FK_Users_CountryId", "Country", "Id")            
            .WithColumn("City").AsString(64).Nullable();
        
        Create.Table("Languages")
            .WithColumn("Id").AsInt32().IdentityKey(this)
            .WithColumn("LanguageId").AsString(10).NotNullable().Unique("IX_Languages_LanguageId")
            .WithColumn("LanguageName").AsString(50);

        Insert.IntoTable("Languages")
            .Row(new { LanguageId = "en", LanguageName = "English" })
            .Row(new { LanguageId = "ru", LanguageName = "Russian" })
            .Row(new { LanguageId = "es", LanguageName = "Spanish" })
            .Row(new { LanguageId = "tr", LanguageName = "Turkish" })
            .Row(new { LanguageId = "de", LanguageName = "German" })
            .Row(new { LanguageId = "zh-CN", LanguageName = "Chinese (Simplified)" })
            .Row(new { LanguageId = "it", LanguageName = "Italian" })
            .Row(new { LanguageId = "pt", LanguageName = "Portuguese" })
            .Row(new { LanguageId = "pt-BR", LanguageName = "Portuguese (Brazil)" })
            .Row(new { LanguageId = "fa", LanguageName = "Farsi" })
            .Row(new { LanguageId = "vi-VN", LanguageName = "Vietnamese (Vietnam)" });

        Create.Table("UserPermissions")
            .WithColumn("UserPermissionId").AsInt64().IdentityKey(this)
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("FK_UserPermissions_UserId", "Users", "UserId")
            .WithColumn("PermissionKey").AsString(100).NotNullable()
            .WithColumn("Granted").AsBoolean().NotNullable().WithDefaultValue(true);

        Create.Index("UQ_UserPerm_UserId_PermKey")
            .OnTable("UserPermissions")
            .OnColumn("UserId").Ascending()
            .OnColumn("PermissionKey").Ascending()
            .WithOptions().Unique();

        Create.Table("Roles")
            .WithColumn("RoleId").AsInt32().IdentityKey(this)
            .WithColumn("RoleName").AsString(100).NotNullable();

        Create.Table("RolePermissions")
            .WithColumn("RolePermissionId").AsInt64().IdentityKey(this)
            .WithColumn("RoleId").AsInt32().NotNullable()
                .ForeignKey("FK_RolePermissions_RoleId", "Roles", "RoleId")
            .WithColumn("PermissionKey").AsString(100).NotNullable();

        Create.Index("UQ_RolePerm_RoleId_PermKey")
            .OnTable("RolePermissions")
            .OnColumn("RoleId").Ascending()
            .OnColumn("PermissionKey").Ascending()
            .WithOptions().Unique();

        Create.Table("UserRoles")
            .WithColumn("UserRoleId").AsInt64().IdentityKey(this)
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("FK_UserRoles_UserId", "Users", "UserId")
            .WithColumn("RoleId").AsInt32().NotNullable()
                .ForeignKey("FK_UserRoles_RoleId", "Roles", "RoleId");

        Create.Index("UQ_UserRoles_UserId_RoleId")
            .OnTable("UserRoles")
            .OnColumn("UserId").Ascending()
            .OnColumn("RoleId").Ascending()
            .WithOptions().Unique();

        Create.Index("IX_UserRoles_RoleId_UserId")
            .OnTable("UserRoles")
            .OnColumn("RoleId").Ascending()
            .OnColumn("UserId").Ascending();

        Create.Table("UserPreferences")
            .WithColumn("UserPreferenceId").AsInt32().IdentityKey(this)
            .WithColumn("UserId").AsInt64().NotNullable()
            .WithColumn("PreferenceType").AsString(100).NotNullable()
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("Value").AsString(int.MaxValue).Nullable();

        Create.Index("IX_UserPref_UID_PrefType_Name")
            .OnTable("UserPreferences")
            .OnColumn("UserId").Ascending()
            .OnColumn("PreferenceType").Ascending()
            .OnColumn("Name").Ascending()
            .WithOptions().Unique();
        
        Create.Table("Exceptions")
            .WithColumn("Id").AsInt64().IdentityKey(this)
            .WithColumn("GUID").AsGuid().NotNullable()
            .WithColumn("ApplicationName").AsString(50).NotNullable()
            .WithColumn("MachineName").AsString(50).NotNullable()
            .WithColumn("CreationDate").AsDateTime().NotNullable()
            .WithColumn("Type").AsString(100).NotNullable()
            .WithColumn("IsProtected").AsBoolean().NotNullable().WithDefaultValue(true)
            .WithColumn("Host").AsString(100).Nullable()
            .WithColumn("Url").AsString(500).Nullable()
            .WithColumn("HTTPMethod").AsString(10).Nullable()
            .WithColumn("IPAddress").AsString(40).Nullable()
            .WithColumn("Source").AsString(100).Nullable()
            .WithColumn("Message").AsString(1000).Nullable()
            .WithColumn("Detail").AsString(int.MaxValue).Nullable()
            .WithColumn("StatusCode").AsInt32().Nullable()
            .WithColumn("SQL").AsString(int.MaxValue).Nullable()
            .WithColumn("DeletionDate").AsDateTime().Nullable()
            .WithColumn("FullJson").AsString(int.MaxValue).Nullable()
            .WithColumn("ErrorHash").AsInt32().Nullable()
            .WithColumn("DuplicateCount").AsInt32().NotNullable().WithDefaultValue(1);

        Create.Index("IX_Exceptions_GUID_App_Del_Cre")
            .OnTable("Exceptions")
            .OnColumn("GUID").Ascending()
            .OnColumn("ApplicationName").Ascending()
            .OnColumn("DeletionDate").Ascending()
            .OnColumn("CreationDate").Descending();

        Create.Index("IX_Exceptions_Hash_App_Cre_Del")
            .OnTable("Exceptions")
            .OnColumn("ErrorHash").Ascending()
            .OnColumn("ApplicationName").Ascending()
            .OnColumn("CreationDate").Descending()
            .OnColumn("DeletionDate").Ascending();

        Create.Index("IX_Exceptions_App_Del_Cre")
            .OnTable("Exceptions")
            .OnColumn("ApplicationName").Ascending()
            .OnColumn("DeletionDate").Ascending()
            .OnColumn("CreationDate").Descending();
    }
}