using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IMovieService : ICRUDService<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest>
    {
    }
}
