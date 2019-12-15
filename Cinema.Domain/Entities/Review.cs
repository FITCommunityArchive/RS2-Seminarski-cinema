using Cinema.Domain.Entities.Identity;

namespace Cinema.Domain.Entities
{
    public class Review : BaseClass
    {
        public string Text { get; set; }
        public decimal Rating { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Movie Movie { get; set; }
    }
}