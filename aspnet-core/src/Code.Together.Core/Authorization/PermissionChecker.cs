using Abp.Authorization;
using Code.Together.Authorization.Roles;
using Code.Together.Authorization.Users;

namespace Code.Together.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
