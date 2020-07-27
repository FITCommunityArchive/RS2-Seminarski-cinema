using Cinema.Shared.Pagination;
using Cinema.Shared.Enums;
using Cinema.Shared.Search;

namespace Cinema.Models.Requests
{
    public class BaseSearchRequest : ISearchRequest
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder? SortOrder { get; set; }
    }
}
