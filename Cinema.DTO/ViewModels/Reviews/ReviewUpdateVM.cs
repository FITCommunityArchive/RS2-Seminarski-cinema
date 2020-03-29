namespace Cinema.DTO.ViewModels.Reviews
{
    public class ReviewUpdateVM
    {
        public int Id { get; set; }
        public MasterModel Movie { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
    }
}