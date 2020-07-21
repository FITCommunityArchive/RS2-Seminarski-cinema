using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models;
using Cinema.Models.Requests;
using Cinema.Utilities.Interfaces;

namespace Cinema.Services
{
    public class MovieService : BaseCRUDService<MovieDto, MovieSearchRequest, Movie, MovieUpsertRequest, MovieUpsertRequest>
    {
        public MovieService(IUnitOfWork unit, IMapper mapper) : base(unit, mapper)
        {

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
