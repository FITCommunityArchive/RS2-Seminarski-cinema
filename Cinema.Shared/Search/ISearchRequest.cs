using Cinema.Shared.Enums;

namespace Cinema.Shared.Search
{
    public interface ISearchRequest
    {
        int PageIndex { get; }
        int PageSize { get; }
        string SortColumn { get; }
        SortOrder? SortOrder { get; }
    }
}
