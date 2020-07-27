using Cinema.Models;
using Cinema.Models.Requests.Movies;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IMovieService : ICRUDService<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest>
    {
    }
}
