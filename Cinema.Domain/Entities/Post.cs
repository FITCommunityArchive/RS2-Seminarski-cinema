using Cinema.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Post : BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }
    }
}
