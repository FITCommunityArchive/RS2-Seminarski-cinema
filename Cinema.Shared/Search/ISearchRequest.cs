using Cinema.Shared.Enums;

namespace Cinema.Shared.Search
{
    public interface ISearchRequest
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        string SortColumn { get; set; }
        SortOrder? SortOrder { get; set; }
        string Includes { get; set; }
    }
}
