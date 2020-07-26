namespace Cinema.Models.Requests.Movies
{
    public class MovieSearchRequest : BaseSearchRequest
    {
        public string SearchTerm { get; set; }
        public int? Year { get; set; }
        public int? Duration { get; set; }
    }
}
