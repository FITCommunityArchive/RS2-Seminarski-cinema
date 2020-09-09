
namespace Cinema.Models.Requests.News
{
    public class NewsSearchRequest : BaseSearchRequest
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int? TypeId { get; set; }
    }
}
