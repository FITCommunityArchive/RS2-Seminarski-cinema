using Cinema.Shared.Constants;
using Cinema.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Cinema.Shared.Pagination
{
    [Obsolete("Use PagedList instead")]
    public class PaginatedList<T> : List<T>, IPagedList<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public string CurrentSort { get; private set; }
        public SortOrder? CurrentSortOrder { get; private set; }
        public string CurrentFilter { get; private set; }
        public List<T> Data { get { return this; } }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public PaginatedList()
        {

        }

        // This is in order to be able to use PagedList in automapper - the list properties aren't mapped successfully
        public PaginatedList(List<T> items, int pageIndex, int totalPages)
        {
            PageIndex = pageIndex;
            TotalPages = totalPages;

            this.AddRange(items);
        }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize,
            SortOrder? currentSortOrder, string currentSort, string currentFilter)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            CurrentSortOrder = currentSortOrder;
            CurrentSort = currentSort;
            CurrentFilter = currentFilter;

            this.AddRange(items);
        }

        public static PaginatedList<T> Create(ICollection<T> source, int pageIndex, int pageSize)
        {
            if (pageIndex == 0)
            {
                pageIndex = Paging.DEFAULT_PAGE_INDEX;
            }

            if (pageSize == 0)
            {
                pageSize = Paging.DEFAULT_PAGE_SIZE;
            }

            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

        public static PaginatedList<T> Create(ICollection<T> source, int pageIndex, int pageSize,
            SortOrder? currentSortOrder, string currentSort, string currentFilter)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<T>(items, count, pageIndex, pageSize,
                currentSortOrder, currentSort, currentFilter);
        }
    }
}
