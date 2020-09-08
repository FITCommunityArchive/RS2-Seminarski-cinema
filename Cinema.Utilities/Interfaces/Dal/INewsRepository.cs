﻿using Cinema.Domain.Entities;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface INewsRepository
    {
        Task<IPagedList<News>> GetPagedAsync(ISearchRequest searchRequest, string title, string author, int? typeId);
    }
}
