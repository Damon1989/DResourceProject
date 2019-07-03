using System.Collections.Generic;
using DResourceProject.Roles.Dto;
using DResourceProject.Users.Dto;

namespace DResourceProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}