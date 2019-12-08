using Microsoft.AspNetCore.Identity;

namespace Cinema.Web.IdentityEntities
{
    public class ApplicationUserToken : IdentityUserToken<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}