using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models;
using Cinema.Models.Requests.Movies;
using Cinema.Shared;
using Cinema.Shared.Helpers;
using Cinema.Utilities.Interfaces;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class MovieService : BaseCRUDService<MovieDto, MovieSearchRequest, Movie, MovieUpsertRequest, MovieUpsertRequest>, IMovieService
    {
        public MovieService(IUnitOfWork unit, IMapper mapper) : base(unit, mapper)
        {

        }

        public override async Task<IPagedList<MovieDto>> GetPagedAsync(MovieSearchRequest search)
        {
            var filterExpression = ApplyFilter(search);
            var sortExpression = ApplySorting(filterExpression, search);

            var list = await _repo.GetPagedAsync(filterExpression, sortExpression, search.SortOrder, search.PageIndex, search.PageSize);
            var dtoList = PagedList<MovieDto>.Map<Movie>(_mapper, list);

            return dtoList;
        }

        private Expression<Func<Movie, object>> ApplySorting(Expression<Func<Movie, bool>> expression, MovieSearchRequest search)
        {
            switch (search.SortColumn)
            {
                case nameof(Movie.Title):              
                    return x => x.Title;
                case nameof(Movie.Year):
                    return x => x.Year;
                default:
                    return x => x.Id;
            }
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
