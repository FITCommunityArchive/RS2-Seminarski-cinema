using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IMovieService : ICRUDService<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest>
    {
        Task<List<MovieDto>> GetNowShowingAsync();
    }
}
