using System;
using System.Collections.Generic;
using System.Text;
using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Cinema.Services.Factory;
using Cinema.DAL.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.BLL
{
    public class MovieService
    {
        protected UnitOfWork _unit;
        public MovieService(UnitOfWork unit)
        {
            _unit = unit;
        }

        public async Task<List<Movie>> GetComingSoonMovies(int quantity = 3)
        {

            //TODO:
            //this is just for a dummy data to give back something. Basically we just need to check if the release date of the movie is newer then the current date
            // problem is we don't have movies higher then 2019 year.

            //additionally we need quantity as well to give back 3 movies 
            List<Movie> movies = await _unit.Movies.GetAsync(x => x.Year == 2019);
            return movies;
        }
    }
}
