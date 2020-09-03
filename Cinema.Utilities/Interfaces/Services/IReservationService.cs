using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IReservationService : ICRUDService<ReservationDto, ReservationSearchRequest, ReservationUpsertRequest, ReservationUpsertRequest>
    {
        Task<bool> ChangeReservationStatus(int id);
        Task<List<ReservationDto>> GetReservationsByUserId(int id);
    }
}
