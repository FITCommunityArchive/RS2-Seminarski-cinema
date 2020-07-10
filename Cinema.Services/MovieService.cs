using AutoMapper;
using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class MovieService : IMovieService
    {
        private readonly UnitOfWork _unit;
        private readonly IMapper _mapper;
        public MovieService(UnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public DtoMovie GetById()
        {

            var entity = _unit.Movies.Get();
            return _mapper.Map<DtoMovie>(entity);
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
