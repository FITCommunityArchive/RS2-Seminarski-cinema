using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class PricingsController : BaseController<PricingDto, BaseSearchRequest>
    {
        public PricingsController(IService<PricingDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
