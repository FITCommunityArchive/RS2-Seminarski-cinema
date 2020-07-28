using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models;
using Cinema.Models.Requests.Movies;
using Cinema.Shared;
using Cinema.Shared.Helpers;
using Cinema.Utilities.Interfaces.Services;
using Cinema.Utilities.Interfaces.Dal;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Cinema.Shared.Pagination;
using Cinema.Dal.Repository;

namespace Cinema.Services
{
    public class MovieService : ICRUDService<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest>, IMovieService
    {
        protected readonly IMovieRepository _movieRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public MovieService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
            _movieRepo = unit.Movies;
        }

        public Task<MovieDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IPagedList<MovieDto>> GetPagedAsync(MovieSearchRequest search)
        {
            var list = await _movieRepo.GetPagedAsync(search, search.SearchTerm, search.Year, search.Duration);
            var dtoList = PagedList<MovieDto>.Map<Movie>(_mapper, list);

            return dtoList;
        }

        public Task<MovieDto> Insert(MovieUpsertRequest req)
        {
            throw new NotImplementedException();
        }

        public Task<MovieDto> Update(int id, MovieUpsertRequest req)
        {
            throw new NotImplementedException();
        }

        private Expression<Func<Movie, bool>> ApplyFilter(MovieSearchRequest search)
        {
            Expression<Func<Movie, bool>> expression = null;

            if (search == null) return null;

            if (!string.IsNullOrEmpty(search.SearchTerm))
            {
                string searchTerm = search.SearchTerm.ToLower();

                Expression<Func<Movie, bool>> tempExpression = x => x.Title.ToLower().Contains(searchTerm)
                               || x.Directors.ToLower().Contains(searchTerm)
                               || x.Actors.ToLower().Contains(searchTerm)
                               || x.Country.ToLower().Contains(searchTerm);

                if (expression == null)
                {
                    expression = tempExpression;
                }
                else
                {
                    expression = ExpressionCombiner.And(expression, tempExpression);
                }                
            }

            if (search.Year.HasValue)
            {
                Expression<Func<Movie, bool>> tempExpression = x => x.Year.ToString().StartsWith(search.Year.ToString());

                if (expression == null)
                {
                    expression = tempExpression;
                }
                else
                {
                    expression = ExpressionCombiner.And(expression, tempExpression);
                }
            }

            if (search.Duration.HasValue)
            {
                Expression<Func<Movie, bool>> tempExpression = x => x.Duration.ToString().StartsWith(search.Duration.ToString());

                if (expression == null)
                {
                    expression = tempExpression;
                }
                else
                {
                    expression = ExpressionCombiner.And(expression, tempExpression);
                }
            }

            return expression;
        }
    }
}
