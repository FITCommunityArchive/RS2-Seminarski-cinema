using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.IdentityEntities
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole()
        {
            UserRoles = new List<ApplicationUserRole>();
            RoleClaims = new List<ApplicationRoleClaim>();
        }
        //public virtual IList<ApplicationUser> Users { get; set; }
        public virtual IList<ApplicationUserRole> UserRoles { get; set; }
        public virtual IList<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
