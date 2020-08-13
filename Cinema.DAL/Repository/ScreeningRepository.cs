﻿using Cinema.Domain.Entities;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Dal.Repository
{
    public class ScreeningRepository : Repository<Screening, int>, IScreeningRepository
    {
        public ScreeningRepository(ICinemaDbContext context) : base(context) { }

        public async Task<IPagedList<Screening>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm, decimal? price, TimingStatus? status, DateTime? screeningDate)
        {
            var query = _dbSet.AsQueryable();

            if (status == null)
            {
                status = TimingStatus.SCHEDULED;
            }

            query = ApplyFilter(query, searchTerm, price, status, screeningDate);

            if (searchRequest.SortOrder == null || searchRequest.SortColumn == null)
            {
                searchRequest.SortOrder = SortOrder.DESC;
                searchRequest.SortColumn = nameof(Screening.DateAndTime);
            }

            query = ApplySorting(query, searchRequest);

            var pagedList = await ApplyPaginationAsync(query, searchRequest.PageIndex, searchRequest.PageSize);
            return pagedList;
        }

        private IQueryable<Screening> ApplyFilter(IQueryable<Screening> query, string searchTerm, decimal? price, TimingStatus? status, DateTime? screeningDate)
        {
            if (screeningDate.HasValue)
            {
                query = query.Where(x => x.DateAndTime.Date == screeningDate.Value.Date);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(x => x.Movie.Title.ToLower().StartsWith(searchTerm.ToLower()));
            }

            if (price.HasValue)
            {
                query = query.Where(x => x.Pricing.Price == price.Value);
            }

            if (screeningDate.HasValue)
            {
                query = query.Where(x => x.DateAndTime.Date == screeningDate.Value);
            }

            if (status.HasValue)
            {
                switch (status.Value)
                {
                    case TimingStatus.STARTED:
                        query = query.Where(x => x.DateAndTime <= DateTime.UtcNow);
                        break;
                    case TimingStatus.SCHEDULED:
                        query = query.Where(x => x.DateAndTime > DateTime.UtcNow);
                        break;
                    default:
                        break;
                }
            }

            return query;
        }

        protected override IQueryable<Screening> ApplySorting(IQueryable<Screening> query, ISearchRequest searchRequest)
        {
            Expression<Func<Screening, object>> expression = GetSortExpression(searchRequest);

            if (searchRequest.SortOrder == SortOrder.ASC)
            {
                query = query.OrderBy(expression);
            }
            else
            {
                query = query.OrderByDescending(expression);
            }

            return query;
        }

        protected override Expression<Func<Screening, object>> GetSortExpression(ISearchRequest searchRequest)
        {
            switch (searchRequest.SortColumn)
            {
                case nameof(Screening.Movie.Title):
                    return x => x.Movie.Title;
                case nameof(Screening.Hall.Name):
                    return x => x.Hall.Name;
                case nameof(Screening.Pricing.Price):
                    return x => x.Pricing.Price;
                case nameof(Screening.DateAndTime):
                    return x => x.DateAndTime;
                case "Status":
                    return x => x.DateAndTime;
                default:
                    return x => x.DateAndTime;
            }
        }
    }
}
