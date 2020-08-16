using Microsoft.AspNetCore.Identity;

namespace Cinema.Domain.Entities.Identity
{
    public class ApplicationUserClaim : IdentityUserClaim<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}