using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Utilities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class PricingService
    {
        protected UnitOfWork _unit;
        private readonly IRepository<Pricing, int> pricingRepo;
        public PricingService()
        {
            pricingRepo = _unit.Repository<Pricing, int>();
        }

        public Pricing PricingTier { get; set; }

        public async Task<Pricing> GetPricingTierAsync(string tier)
        {
            //gets reserved seats first
            PricingTier = await pricingRepo.Get().AsQueryable().FirstOrDefaultAsync(x => x.Name == tier);

            return PricingTier;
        }
    }
}
