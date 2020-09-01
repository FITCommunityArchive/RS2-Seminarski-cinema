using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Models.SpecificModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IScreeningService : ICRUDService<ScreeningDto, ScreeningSearchRequest, ScreeningUpsertRequest, ScreeningUpsertRequest>
    {
        Task<List<SeatingModel>> GetSeatingAsync(int id);
        Task<bool> AreSeatsFreeAsync(int id, IEnumerable<int> seatIds);
    }
}
