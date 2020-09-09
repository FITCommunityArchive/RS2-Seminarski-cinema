using Cinema.Domain.Entities.Identity;

namespace Cinema.Domain.Entities
{
    public class Post : BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }
    }
}
