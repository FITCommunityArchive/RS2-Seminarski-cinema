namespace Cinema.Models.Requests.News
{
    public class NewsUpsertRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int TypeId { get; set; }
        public int AuthorId { get; set; }
    }
}
