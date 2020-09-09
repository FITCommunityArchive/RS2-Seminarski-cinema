using Cinema.Domain.Entities;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.EntityFrameworkCore;
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

            if (!searchRequest.ReturnAll)
            {
                query = ApplyFilter(query, searchTerm, searchYear, searchDuration);
            }

            if (searchRequest.SortOrder != null && searchRequest.SortColumn != null)
            {
                query = ApplySorting(query, searchRequest);
            }

            var pagedList = await ApplyPaginationAsync(query, searchRequest.PageIndex, searchRequest.PageSize, searchRequest.ReturnAll);
            return pagedList;
        }

        public async Task<Movie> GetByIdWithGenresAsync(int id)
        {
            var entity = await _dbSet.Include(x => x.GenreMovies)
                                     .FirstOrDefaultAsync(x => x.Id == id);

            return entity;
        }

        private IQueryable<Movie> ApplyFilter(IQueryable<Movie> query, string searchTerm, int? searchYear, int? searchDuration)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.ToLower();

                query = query.Where(x => x.Title.ToLower().StartsWith(searchTerm)
                               || x.Directors.ToLower().StartsWith(searchTerm)
                               || x.Actors.ToLower().StartsWith(searchTerm)
                               || x.Country.ToLower().StartsWith(searchTerm));
            }

            if (searchYear.HasValue)
            {
                query = query.Where(x => x.Year.ToString().StartsWith(searchYear.ToString()));
            }

            if (searchDuration.HasValue)
            {
                query = query.Where(x => x.Duration.ToString().StartsWith(searchDuration.ToString()));
            }

            return query;
        }

        protected override IQueryable<Movie> ApplySorting(IQueryable<Movie> query, ISearchRequest searchRequest)
        {
            Expression<Func<Movie, object>> expression = GetSortExpression(searchRequest);

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

        protected override Expression<Func<Movie, object>> GetSortExpression(ISearchRequest searchRequest)
        {
            switch (searchRequest.SortColumn)
            {
                case nameof(Movie.Title):
                    return x => x.Title;
                case nameof(Movie.Year):
                    return x => x.Year;
                case nameof(Movie.Duration):
                    return x => x.Duration;
                case nameof(Movie.Country):
                    return x => x.Country;
                case nameof(Movie.Directors):
                    return x => x.Directors;
                case nameof(Movie.Actors):
                    return x => x.Actors;
                default:
                    return x => x.Id;
            }
        }

        public double GetMovieReviewScore(int id)
        {
            var score = _context.Reviews.Where(x => x.MovieId == id).Average(x => (int?)x.Rating) ?? 0;

            return score;
        }
    }
}
