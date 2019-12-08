using Microsoft.AspNetCore.Identity;

namespace Cinema.Web.IdentityEntities
{
    public class ApplicationRoleClaim : IdentityRoleClaim<int>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}