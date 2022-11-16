using System.Collections.Generic;
using IhaleProject.Roles.Dto;

namespace IhaleProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}