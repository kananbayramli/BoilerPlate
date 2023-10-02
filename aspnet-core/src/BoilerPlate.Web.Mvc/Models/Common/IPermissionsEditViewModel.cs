using System.Collections.Generic;
using BoilerPlate.Roles.Dto;

namespace BoilerPlate.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}