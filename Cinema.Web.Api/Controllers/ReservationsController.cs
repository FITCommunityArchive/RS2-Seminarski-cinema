using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class ReservationsController : BaseCRUDController<ReservationDto, ReservationSearchRequest, ReservationUpsertRequest, ReservationUpsertRequest>
    {
        public ReservationsController(IReservationService service) : base(service)
        {
        }
    }
}
