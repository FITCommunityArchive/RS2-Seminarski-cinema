using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Models.SpecificModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Common.Interfaces.Services
{
    public interface IScreeningService : ICRUDService<ScreeningDto, ScreeningSearchRequest, ScreeningUpsertRequest, ScreeningUpsertRequest>
    {
        Task<List<ScreeningDto>> GetAsync(ScreeningSearchRequest search);
        Task<List<SeatingModel>> GetSeatingAsync(int id);
        Task<bool> AreSeatsFreeAsync(int id, IEnumerable<int> seatIds);
    }
}
