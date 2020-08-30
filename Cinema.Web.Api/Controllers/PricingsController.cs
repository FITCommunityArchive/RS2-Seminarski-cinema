using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Models.Requests.Pricing;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class PricingsController : BaseCRUDController<PricingDto,PricingSearchRequest,PricingUpsertRequest,PricingUpsertRequest>
    {
        
        public PricingsController(ICRUDService<PricingDto, PricingSearchRequest, PricingUpsertRequest, PricingUpsertRequest> service) : base(service)
        {
            
        }
    }
}
