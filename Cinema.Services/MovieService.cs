using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models;
using Cinema.Models.Requests.Movies;
using Cinema.Shared;
using Cinema.Utilities.Interfaces;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class MovieService : BaseCRUDService<MovieDto, MovieSearchRequest, Movie, MovieUpsertRequest, MovieUpsertRequest>, IMovieService
    {
        public MovieService(IUnitOfWork unit, IMapper mapper) : base(unit, mapper)
        {

        }

        public override async Task<PagedList<MovieDto>> GetPagedAsync(MovieSearchRequest search)
        {
            var expression = ApplyFilter(search);

            var list = await _repo.GetPagedAsync(expression, search.PageIndex, search.PageSize);
            var dtoList = _mapper.Map<PagedList<MovieDto>>(list);

            return dtoList;
        }

        private Expression<Func<Movie, bool>> ApplyFilter(MovieSearchRequest search)
        {
            if (search == null) return null;

            if (!string.IsNullOrEmpty(search.SearchTerm))
            {
                return x => x.Title.ToLower().Contains(search.SearchTerm.ToLower());
            }

            return null;
        }
    }
}
