namespace Cinema.Dto.ViewModels.Reviews
{
    public class ReviewCreateVM
    {
        public int Id { get; set; }
        public MasterModel Movie { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
    }
}