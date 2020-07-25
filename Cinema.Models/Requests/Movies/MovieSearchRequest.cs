namespace Cinema.Models.Requests.Movies
{
    public class MovieSearchRequest : BaseSearchRequest
    {
        public string SearchTerm { get; set; }
    }
}
