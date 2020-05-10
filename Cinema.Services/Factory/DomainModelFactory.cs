using Cinema.Domain.Entities;
using Cinema.DTO.DomainModels;
using System.Linq;

namespace Cinema.Services.Factory
{
    /*These methods create generic models out of domain classes,
     where the only difference between a model and the corresponding domain class is 
     that MasterModels are used as parent/child object properties instead of domain classes*/
    public static class DomainModelFactory
    {
        public static MovieModel Create(this Movie movie)
        {
            return new MovieModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Duration = movie.Duration,
                Year = movie.Year,
                Country = movie.Country,
                Image = movie.Image,
                VideoLink = movie.VideoLink,
                Directors = movie.Directors,
                Actors = movie.Actors,
                Screenings = movie.Screenings.Select(x => x.CreateMaster()).ToList(),
                Reviews = movie.Reviews.Select(x => x.CreateMaster()).ToList(),
                GenreMovies = movie.GenreMovies.Select(x => x.CreateMaster()).ToList()
            };
        }

        public static GenreMovieModel Create(this GenreMovie genreMovie)
        {
            return new GenreMovieModel
            {
                Id = genreMovie.Id,
                Movie = genreMovie.Movie.CreateMaster(),
                Genre = genreMovie.Genre.CreateMaster()
            };
        }
    }
}
