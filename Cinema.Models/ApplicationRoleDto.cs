using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
    public class ApplicationRoleDto
    {

        public ApplicationRoleDto()
        {
            UserRoles = new List<ApplicationUserRoleDto>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public IList<ApplicationUserRoleDto> UserRoles { get; set; }
    }
}
