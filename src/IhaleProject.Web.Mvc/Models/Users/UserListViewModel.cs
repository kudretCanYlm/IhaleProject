using System.Collections.Generic;
using IhaleProject.Roles.Dto;

namespace IhaleProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
