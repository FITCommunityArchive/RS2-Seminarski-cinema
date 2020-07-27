using System.Collections.Generic;

namespace Cinema.Shared.Pagination
{
    public interface IPagedList<T>
    {
        List<T> Data { get; }
        int PageIndex { get; }
        int TotalPages { get; }
        string CurrentSort { get; }
        string CurrentFilter { get; }
    }
}
