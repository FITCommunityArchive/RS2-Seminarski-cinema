using Cinema.Domain.Entities.Identity;
using Cinema.DTO;

namespace Cinema.DTO.ViewModels.Reviews
{
    public class ReviewIndexVM
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public IdentityMasterModel User { get; set; }
        public MasterModel Movie { get; set; }
    }
}