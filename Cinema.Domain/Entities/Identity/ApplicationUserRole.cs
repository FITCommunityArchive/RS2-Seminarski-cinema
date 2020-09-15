using Microsoft.AspNetCore.Identity;

namespace Cinema.Domain.Entities.Identity
{
    //If the user has only one role, this Table will be obsolete
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        public ApplicationUserRole()
        {
            IsDeleted = false;
        }
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
        public bool IsDeleted { get; set; }
    }
}