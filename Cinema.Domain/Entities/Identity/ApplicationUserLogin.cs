using Microsoft.AspNetCore.Identity;

namespace Cinema.Domain.Entities.Identity
{
    public class ApplicationUserLogin : IdentityUserLogin<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}