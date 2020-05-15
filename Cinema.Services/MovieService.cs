using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class MovieService
    {
        protected UnitOfWork _unit;
        public MovieService(UnitOfWork unit)
        {
            _unit = unit;
        }

        public async Task<IEnumerable<Movie>> GetComingSoonMovies(int quantity)
        {
            IEnumerable<Movie> movies = (await _unit.Movies.GetAsync(x => x.Year >= 2015)).Take(quantity);
            return movies;
        }

        public async Task<IEnumerable<Screening>> GetNowShowingScreenings(int quantity)
        {
            IEnumerable<Screening> screenings = (await _unit.Screenings.GetAsync(x => x.Movie.Year >= 2005)).GroupBy(y => y.MovieId).Select(z => z.First()).Take(quantity);
            return screenings;
        }
    }
}
