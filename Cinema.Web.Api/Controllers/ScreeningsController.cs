using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Models.SpecificModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    public class ScreeningsController : BaseCRUDController<ScreeningDto, ScreeningSearchRequest, ScreeningUpsertRequest, ScreeningUpsertRequest>
    {
        private readonly IScreeningService _screeningService;
        public ScreeningsController(IScreeningService service) : base(service)
        {
            _screeningService = service;
        }

        [HttpGet("{id}/seating")]
        public async Task<ActionResult<List<SeatingModel>>> GetSeating(int id)
        {
            var result = await _screeningService.GetSeatingAsync(id);
            return Ok(result);
        }
    }
}
