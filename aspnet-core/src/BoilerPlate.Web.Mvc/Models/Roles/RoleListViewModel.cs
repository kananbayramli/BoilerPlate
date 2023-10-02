using System.Collections.Generic;
using BoilerPlate.Roles.Dto;

namespace BoilerPlate.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
