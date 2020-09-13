using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using System.Threading.Tasks;

namespace Cinema.Common.Interfaces.Services
{
    public interface IReservationService : ICRUDService<ReservationDto, ReservationSearchRequest, ReservationUpsertRequest, ReservationUpsertRequest>
    {
        Task<bool> ChangeReservationStatus(int id);
    }
}
