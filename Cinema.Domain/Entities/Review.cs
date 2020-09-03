using Cinema.Domain.Entities.Identity;

namespace Cinema.Domain.Entities
{
    public class Review : BaseClass
    {
        public string Text { get; set; }
        public int Rating { get; set; }

        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}