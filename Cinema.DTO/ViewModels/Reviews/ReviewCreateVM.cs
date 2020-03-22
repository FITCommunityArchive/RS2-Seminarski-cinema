namespace Cinema.DTO.ViewModels.Reviews
{
    public class ReviewCreateVM
    {
        public MasterModel Movie { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
        public bool IsAlreadyRated { get; set; }
    }
}