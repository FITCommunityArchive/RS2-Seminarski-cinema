using AutoMapper;
using Cinema.Shared.Constants;
using Cinema.Shared.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Cinema.Shared.Pagination
{
    public class PagedList<T> : IPagedList<T>
    {
        [JsonProperty]
        public List<T> Data { get; private set; }
        [JsonProperty]
        public int PageIndex { get; private set; }
        [JsonProperty]
        public int TotalPages { get; private set; }
        [JsonProperty]
        public string CurrentSort { get; private set; }
        [JsonProperty]
        public SortOrder? CurrentSortOrder { get; private set; }
        [JsonProperty]
        public string CurrentFilter { get; private set; }

        [JsonProperty]
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        [JsonProperty]

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public PagedList()
        {

        }

        public PagedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            Data = items;
        }

        public PagedList(List<T> items, int count, int pageIndex, int pageSize,
            SortOrder? currentSortOrder, string currentSort, string currentFilter)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            CurrentSortOrder = currentSortOrder;
            CurrentSort = currentSort;
            CurrentFilter = currentFilter;

            Data = items;
        }

        public static PagedList<T> Map<TSource>(IMapper mapper, IPagedList<TSource> sourceList) where TSource : class
        {
            var data = mapper.Map<List<T>>(sourceList.Data);

            return new PagedList<T>
            {
                Data = data,
                PageIndex = sourceList.PageIndex,
                TotalPages = sourceList.TotalPages
            };
        }

        public static PagedList<T> Create(ICollection<T> source, int pageIndex, int pageSize)
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

        public static PagedList<T> Create(ICollection<T> source, int pageIndex, int pageSize,
            SortOrder? currentSortOrder, string currentSort, string currentFilter)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageIndex, pageSize,
                currentSortOrder, currentSort, currentFilter);
        }
    }
}
