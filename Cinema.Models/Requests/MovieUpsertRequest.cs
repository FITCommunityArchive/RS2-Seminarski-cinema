namespace Cinema.Models.Requests
{
    public class MovieUpsertRequest
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string VideoLink { get; set; }
        public string Directors { get; set; }
        public string Actors { get; set; }
    }
}
