namespace Cinema.Dto.ViewModels.Reviews
{
    public class ReviewIndexVM
    {
        public int ReviewId { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public IdentityMasterModel User { get; set; }
        public MasterModel Movie { get; set; }
    }
}