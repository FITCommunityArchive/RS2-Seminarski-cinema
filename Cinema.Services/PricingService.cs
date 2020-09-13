using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Pricing;
using Cinema.Common.Interfaces.Dal;

namespace Cinema.Services
{
    public class PricingService : BaseCRUDService<PricingDto, PricingSearchRequest, Pricing, PricingUpsertRequest, PricingUpsertRequest>
    {
        public PricingService(IUnitOfWork unit, IMapper mapper) : base(unit, mapper)
        {
        }
    }
}
