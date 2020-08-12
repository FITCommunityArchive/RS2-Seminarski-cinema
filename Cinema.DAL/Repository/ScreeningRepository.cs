using Cinema.Domain.Entities;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Interfaces.Dal;
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

        public async Task<IPagedList<Screening>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm, DateTime? screeningDate)
        {
            var query = _dbSet.AsQueryable();

            query = ApplyFilter(query, searchTerm, screeningDate);

            if (searchRequest.SortOrder != null && searchRequest.SortColumn != null)
            {
                query = ApplySorting(query, searchRequest);
            }

            var pagedList = await ApplyPaginationAsync(query, searchRequest.PageIndex, searchRequest.PageSize);
            return pagedList;
        }

        private IQueryable<Screening> ApplyFilter(IQueryable<Screening> query, string searchTerm, DateTime? screeningDate)
        {
            if (screeningDate.HasValue)
            {
                query = query.Where(x => x.DateAndTime.Date == screeningDate.Value.Date);
            }

            return query;
        }
    }
}
