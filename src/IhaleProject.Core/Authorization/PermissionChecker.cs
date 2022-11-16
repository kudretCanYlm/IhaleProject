using Abp.Authorization;
using IhaleProject.Authorization.Roles;
using IhaleProject.Authorization.Users;

namespace IhaleProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
