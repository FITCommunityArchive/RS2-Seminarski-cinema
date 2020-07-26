using Cinema.Shared.Enums;

namespace Cinema.Models.Requests
{
    public class BaseSearchRequest
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder? SortOrder { get; set; }
    }
}
