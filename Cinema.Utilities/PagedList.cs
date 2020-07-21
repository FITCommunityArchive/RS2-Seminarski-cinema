using Cinema.Utilities.Constants;
using Cinema.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema.Utilities
{
    public class PagedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public string CurrentSort { get; private set; }
        public SortOrder? CurrentSortOrder { get; private set; }
        public string CurrentFilter { get; private set; }

        public PagedList()
        {

        }

        public PagedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public PagedList(List<T> items, int count, int pageIndex, int pageSize,
            SortOrder? currentSortOrder, string currentSort, string currentFilter)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            CurrentSortOrder = currentSortOrder;
            CurrentSort = currentSort;
            CurrentFilter = currentFilter;

            this.AddRange(items);
        }

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

        public static PagedList<T> Create(IQueryable<T> source, int pageIndex, int pageSize)
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
            return new PagedList<T>(items, count, pageIndex, pageSize);
        }

        public static PagedList<T> Create(IQueryable<T> source, int pageIndex, int pageSize,
            SortOrder? currentSortOrder, string currentSort, string currentFilter)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageIndex, pageSize,
                currentSortOrder, currentSort, currentFilter);
        }        
    }
}
