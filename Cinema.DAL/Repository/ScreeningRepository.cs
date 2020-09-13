using Cinema.Domain.Entities;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Screening>> GetAsync(ISearchRequest searchRequest, string searchTerm, int? movieId, string hall, decimal? price, TimingStatus? status, DateTime? screeningDate)
        {
            IQueryable<Screening> query = GetFilteredQueryable(searchRequest, searchTerm, movieId, hall, price, ref status, screeningDate);

            return await query.ToListAsync();
        }

        public async Task<IPagedList<Screening>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm, int? movieId, string hall, decimal? price, TimingStatus? status, DateTime? screeningDate)
        {
            var query = GetFilteredQueryable(searchRequest, searchTerm, movieId, hall, price, ref status, screeningDate);

            var pagedList = await ApplyPaginationAsync(query, searchRequest.PageIndex, searchRequest.PageSize);
            return pagedList;
        }

        private IQueryable<Screening> GetFilteredQueryable(ISearchRequest searchRequest, string searchTerm, int? movieId, string hall, decimal? price, ref TimingStatus? status, DateTime? screeningDate)
        {
            var query = _dbSet.AsQueryable();

            if (status == null)
            {
                status = TimingStatus.SCHEDULED;
            }

            query = ApplyFilter(query, searchTerm, movieId, hall, price, status, screeningDate);

            if (searchRequest.SortOrder == null || searchRequest.SortColumn == null)
            {
                searchRequest.SortOrder = SortOrder.DESC;
                searchRequest.SortColumn = nameof(Screening.DateAndTime);
            }

            query = ApplySorting(query, searchRequest);

            if (searchRequest.Includes.Count() > 0)
            {
                query = AddIncludes(query, searchRequest.Includes);
            }

            return query;
        }

        public async Task<IEnumerable<Screening>> GetWithSeatReservations(ISearchRequest searchRequest, string searchTerm, int? movieId, string hall, decimal? price, TimingStatus? status, DateTime? screeningDate)
        {
            var query = _dbSet.Include(x => x.Movie)
                              .Include(x => x.Hall)
                              .Include(x => x.Reservations).ThenInclude(x => x.SeatReservations)
                              .AsQueryable();

            if (status == null)
            {
                status = TimingStatus.SCHEDULED;
            }

            query = ApplyFilter(query, searchTerm, movieId, hall, price, status, screeningDate);

            if (searchRequest.SortOrder == null || searchRequest.SortColumn == null)
            {
                searchRequest.SortOrder = SortOrder.DESC;
                searchRequest.SortColumn = nameof(Screening.DateAndTime);
            }

            query = ApplySorting(query, searchRequest);

            return await query.ToListAsync();
        }

        protected override Expression<Func<Screening, bool>> GetByIdExpression(int id)
        {
            return x => x.Id == id;
        }

        private IQueryable<Screening> ApplyFilter(IQueryable<Screening> query, string searchTerm, int? movieId, string hall, decimal? price, TimingStatus? status, DateTime? screeningDate)
        {

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(x => x.Movie.Title.ToLower().StartsWith(searchTerm.ToLower()));
            }

            if (movieId.HasValue)
            {
                query = query.Where(x => x.MovieId == movieId.Value);
            }

            if (screeningDate.HasValue)
            {
                query = query.Where(x => x.DateAndTime.Date == screeningDate.Value.Date);
            }

            if (!string.IsNullOrWhiteSpace(hall))
            {
                query = query.Where(x => x.Hall.Name.ToLower().StartsWith(hall.ToLower()));
            }

            if (price.HasValue)
            {
                query = query.Where(x => x.Pricing.Price.ToString().StartsWith(price.Value.ToString()));
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
