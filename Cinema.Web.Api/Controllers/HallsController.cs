using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests;

namespace Cinema.Web.Api.Controllers
{
    public class HallsController : BaseController<HallDto, BaseSearchRequest>
    {
        public HallsController(IService<HallDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
