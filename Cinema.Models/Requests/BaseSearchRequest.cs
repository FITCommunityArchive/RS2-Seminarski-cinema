using Cinema.Shared.Enums;
using Cinema.Shared.Search;
using System.Collections.Generic;

namespace Cinema.Models.Requests
{
    public class BaseSearchRequest : ISearchRequest
    {
        public BaseSearchRequest()
        {
            Includes = new List<string>();
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder? SortOrder { get; set; }
        public ICollection<string> Includes { get; set; }
        public bool ReturnAll { get; set; } = false;
    }
}
