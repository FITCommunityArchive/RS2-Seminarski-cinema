using Microsoft.AspNetCore.Identity;

namespace Cinema.Web.IdentityEntities
{
    public class ApplicationUserLogin : IdentityUserLogin<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}