using AutoMapper;
using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Models;
using Cinema.Utilities.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unit;
        private readonly IRepository<Movie, int> movieRepo;
        private readonly IMapper _mapper;
        public MovieService(IMapper mapper)
        {
            movieRepo = _unit.Repository<Movie,int>();
            _mapper = mapper;
        }

        public DtoMovie GetById()
        {

            var entity = movieRepo.Get();
            return _mapper.Map<DtoMovie>(entity);
        }

        public List<DtoMovie> Get()
        {
            var movies = movieRepo.Get().ToList();
            return _mapper.Map<List<DtoMovie>>(movies);
        }

        //public async Task<IEnumerable<DtoMovie>> GetComingSoonMovies(int quantity)
        //{
        //    IEnumerable<DtoMovie> movies = (await _unit.Movies.GetAsync(x => x.Year >= 2015)).Take(quantity);
        //    return movies;
        //}

        //public async Task<IEnumerable<Screening>> GetNowShowingScreenings(int quantity)
        //{
        //    IEnumerable<Screening> screenings = (await _unit.Screenings.GetAsync(x => x.Movie.Year >= 2005)).GroupBy(y => y.MovieId).Select(z => z.First()).Take(quantity);
        //    return screenings;
        //}
    }
}
