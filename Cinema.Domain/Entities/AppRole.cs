using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class AppRole : BaseType
    {
        public AppRole()
        {
            Users = new List<User>();
        }
        public virtual IList<User> Users { get; set; }
    }
}