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
    }
}
