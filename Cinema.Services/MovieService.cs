using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System;
using System.Threading.Tasks;

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

        public async Task<MovieDto> GetByIdAsync(int id)
        {
            var entity = await _movieRepo.GetByIdWithGenresAsync(id);
            return _mapper.Map<MovieDto>(entity);
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
