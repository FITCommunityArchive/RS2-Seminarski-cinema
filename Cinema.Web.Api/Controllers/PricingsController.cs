using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Pricing;

namespace Cinema.Web.Api.Controllers
{
    public class PricingsController : BaseCRUDController<PricingDto, PricingSearchRequest, PricingUpsertRequest, PricingUpsertRequest>
    {

        public PricingsController(ICRUDService<PricingDto, PricingSearchRequest, PricingUpsertRequest, PricingUpsertRequest> service) : base(service)
        {

        }
    }
}
