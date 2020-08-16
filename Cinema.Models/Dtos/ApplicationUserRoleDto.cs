using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Dtos
{
    public class ApplicationUserRoleDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public ApplicationUserDto User { get; set; }
        public ApplicationRoleDto Role { get; set; }
    }
}
