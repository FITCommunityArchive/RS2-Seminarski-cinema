namespace Cinema.DTO.ViewModels.Reviews
{
    public class ReviewCreateVM
    {
        public ReviewCreateVM(int movieId)
        {
            MovieId = movieId;
        }

        public int MovieId { get; set; }
        public int Rating { get; set; }
    }
}