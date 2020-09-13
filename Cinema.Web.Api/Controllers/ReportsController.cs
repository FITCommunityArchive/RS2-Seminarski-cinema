using Cinema.Models.Dtos;
using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reports;
using Cinema.Models.Requests.Reservations;
using Cinema.Common.Interfaces.Services;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]

    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;
        public ReportsController(IReportService service)
        {
            _reportService = service;
        }

        [HttpGet("user-yearly-sales")]
        public async Task<ActionResult<YearlySalesReportDto>> GetYearlyUserSales([FromQuery] UserYearlySalesSearchRequest searchRequest)
        {
            var result = await _reportService.GetYearlySalesReportPerUserAsync(searchRequest);
            return Ok(result);
        }

        [HttpGet("screening-capacities")]
        public async Task<ActionResult<PagedList<ScreeningCapacityDto>>> GetYearlyUserSales([FromQuery] ScreeningSearchRequest searchRequest)
        {
            var result = await _reportService.GetScreeningCapacitiesAsync(searchRequest);
            return Ok(result);
        }
    }
}
