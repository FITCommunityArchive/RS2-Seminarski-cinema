using Microsoft.AspNetCore.Identity;

namespace Cinema.Web.IdentityEntities
{
    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}