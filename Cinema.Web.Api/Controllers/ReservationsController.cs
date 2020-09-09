using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    public class ReservationsController : BaseCRUDController<ReservationDto, ReservationSearchRequest, ReservationUpsertRequest, ReservationUpsertRequest>
    {
        private readonly IReservationService _reservationService;
        public ReservationsController(IReservationService service) : base(service)
        {
            _reservationService = service;
        }

        [HttpPut("{id}/status")]
        public async Task<ActionResult<bool>> ChangeReservationStatus(int id)
        {
            var result = await _reservationService.ChangeReservationStatus(id);
            return Ok(result);
        }
    }
}
