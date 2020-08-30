using AutoMapper;
using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Pricing;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class PricingService : BaseCRUDService<PricingDto,PricingSearchRequest,Pricing,PricingUpsertRequest,PricingUpsertRequest>
    {
        public PricingService(IUnitOfWork unit, IMapper mapper) : base(unit,mapper)
        {
        }
    }
}
