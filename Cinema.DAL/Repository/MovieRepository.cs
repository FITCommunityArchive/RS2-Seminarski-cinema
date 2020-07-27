using Cinema.Domain.Entities;
using Cinema.Shared;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Interfaces.Dal;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Dal.Repository
{
    public class MovieRepository : Repository<Movie, int>, IMovieRepository
    {
        public MovieRepository(ICinemaDbContext context) : base(context) { }

        public async Task<IPagedList<Movie>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm, int? searchYear, int? searchDuration)
        {
            var query = _dbSet.AsQueryable();

            if (searchRequest.SortOrder != null && searchRequest.SortColumn != null)
            {
                query = Sort(query, searchRequest);
            }

            var pagedList = await ApplyPaginationAsync(query, searchRequest.PageIndex, searchRequest.PageSize);
            return pagedList;
        }

        protected override IQueryable<Movie> Sort(IQueryable<Movie> query, ISearchRequest searchRequest)
        {            
            switch (searchRequest.SortColumn)
            {
                case nameof(Movie.Title):
                    return query.OrderBy(x => x.Title);
                case nameof(Movie.Year):
                    return query.OrderBy(x => x.Year);
                default:
                    return query.OrderBy(x => x.Id);
            }
        }
    }
}
