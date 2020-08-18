using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class ScreeningsController : BaseCRUDController<ScreeningDto, ScreeningSearchRequest, ScreeningUpsertRequest, ScreeningUpsertRequest>
    {
        public ScreeningsController(ICRUDService<ScreeningDto, ScreeningSearchRequest, ScreeningUpsertRequest, ScreeningUpsertRequest> service) : base(service)
        {
        }
    }
}
