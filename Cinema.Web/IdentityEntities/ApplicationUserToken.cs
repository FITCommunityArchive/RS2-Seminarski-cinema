using Microsoft.AspNetCore.Identity;

namespace Cinema.Web.IdentityEntities
{
    public class ApplicationUserToken : IdentityUserToken<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}