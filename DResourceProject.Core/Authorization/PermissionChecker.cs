using Abp.Authorization;
using DResourceProject.Authorization.Roles;
using DResourceProject.Authorization.Users;

namespace DResourceProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
