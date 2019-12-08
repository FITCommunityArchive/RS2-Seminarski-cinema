using Microsoft.AspNetCore.Identity;

namespace Cinema.Domain.Entities.Identity
{
    public class ApplicationUserToken : IdentityUserToken<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}