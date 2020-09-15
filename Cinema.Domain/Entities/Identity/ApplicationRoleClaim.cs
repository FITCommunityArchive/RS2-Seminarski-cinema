using Microsoft.AspNetCore.Identity;

namespace Cinema.Domain.Entities.Identity
{
    public class ApplicationRoleClaim : IdentityRoleClaim<int>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}