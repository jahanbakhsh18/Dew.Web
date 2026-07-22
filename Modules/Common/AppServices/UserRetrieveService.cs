using Dew.Administration;
using MyRow = Dew.Administration.UserRow;

namespace Dew.AppServices;

public class UserRetrieveService(ITwoLevelCache cache, ISqlConnections sqlConnections)
    : BaseUserRetrieveService<MyRow>(cache, sqlConnections)
{
    protected override UserDefinition ToUserDefinition(MyRow user)
    {
        return new UserDefinition
        {
            UserId = user.UserId.Value,
            Username = user.Username,
            Email = user.Email,
            UserImage = user.UserImage,
            DisplayName = user.DisplayName,
            IsActive = user.IsActive.Value,
            Source = user.Source,
            PasswordHash = user.PasswordHash,
            PasswordSalt = user.PasswordSalt,
            UpdateDate = user.UpdateDate,
            LastDirectoryUpdate = user.LastDirectoryUpdate
        };
    }

    protected override IUserDefinition LoadByCriteria(IDbConnection connection, BaseCriteria criteria)
    {
        var userDef = base.LoadByCriteria(connection, criteria) as UserDefinition;
        if (userDef == null)
            return null;

        var userRoleFields = UserRoleRow.Fields.As("ur");
        var roleFields = RoleRow.Fields.As("r");

        var query = new SqlQuery()
            .From(userRoleFields)
            .Select(roleFields.RoleName)
            .InnerJoin(roleFields,
                userRoleFields.RoleId == roleFields.RoleId)
            .Where(userRoleFields.UserId == userDef.UserId);

        var roleNames = connection.Query<string>(query).ToList();

        userDef.RoleNames = roleNames.ToArray();
        return userDef;
    }


}