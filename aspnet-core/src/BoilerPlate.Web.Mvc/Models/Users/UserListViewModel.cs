using System.Collections.Generic;
using BoilerPlate.Roles.Dto;

namespace BoilerPlate.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
