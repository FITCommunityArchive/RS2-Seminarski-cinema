using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Models.Requests.Screenings;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IScreeningService : ICRUDService<ScreeningDto, ScreeningSearchRequest, ScreeningUpsertRequest, ScreeningUpsertRequest>
    {
    }
}
