using Microsoft.AspNetCore.Identity;

namespace Cinema.Domain.Entities.Identity
{ 
    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}