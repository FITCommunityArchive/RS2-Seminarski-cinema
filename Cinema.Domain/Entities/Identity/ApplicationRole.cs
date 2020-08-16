using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Cinema.Domain.Entities.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        public ApplicationRole()
        {
            UserRoles = new List<ApplicationUserRole>();
            //Users = new List<ApplicationUser>();
            RoleClaims = new List<ApplicationRoleClaim>();
            Deleted = false;
        }
        public bool Deleted { get; set; }
        //public virtual IList<ApplicationUser> Users { get; set; }
        public virtual IList<ApplicationUserRole> UserRoles { get; set; }
        public virtual IList<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
