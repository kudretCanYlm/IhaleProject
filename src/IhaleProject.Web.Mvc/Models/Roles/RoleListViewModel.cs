using System.Collections.Generic;
using IhaleProject.Roles.Dto;

namespace IhaleProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
