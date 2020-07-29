using Cinema.Shared.Enums;
using System.Collections.Generic;

namespace Cinema.Shared.Pagination
{
    public interface IPagedList<T>
    {
        List<T> Data { get; }
        int PageIndex { get; }
        int TotalPages { get; }
        string SortColumn { get; }
        string CurrentFilter { get; }
    }
}
