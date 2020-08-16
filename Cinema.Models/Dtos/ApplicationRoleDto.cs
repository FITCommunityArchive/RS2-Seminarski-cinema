using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Dtos
{
    public class ApplicationRoleDto
    {

        public ApplicationRoleDto()
        {
            UserRoles = new List<ApplicationUserRoleDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public IList<ApplicationUserRoleDto> UserRoles { get; set; }
    }
}
