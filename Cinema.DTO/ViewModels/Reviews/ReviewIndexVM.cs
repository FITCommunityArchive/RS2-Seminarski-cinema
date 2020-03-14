using Cinema.Domain.Entities.Identity;
using Cinema.DTO;

namespace Cinema.Domain.Entities
{
    public class ReviewIndexVM
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public decimal Rating { get; set; }
        public MasterModel User { get; set; }
        public MasterModel Movie { get; set; }
    }
}