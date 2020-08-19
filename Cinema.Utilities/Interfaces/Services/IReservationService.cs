using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IReservationService : ICRUDService<ReservationDto, ReservationSearchRequest, ReservationUpsertRequest, ReservationUpsertRequest>
    {
    }
}
