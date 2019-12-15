using Microsoft.AspNetCore.Identity;

namespace Cinema.Domain.Entities.Identity
{
    //If the user has only one role, this Table will be obsolete
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}