using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.IdentityEntities
{
    public class ApplicationUser : IdentityUser
    {
        //string is the PK type of IdentityUser
        public string CustomTag { get; set; }
        public virtual IList<ApplicationUserClaim> Claims { get; set; }
        public virtual IList<ApplicationUserLogin> Logins { get; set; }
        public virtual IList<ApplicationUserToken> Tokens { get; set; }
        public virtual IList<ApplicationUserRole> UserRoles { get; set; }
    }
}
