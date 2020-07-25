using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Shared
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
