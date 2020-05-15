using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class PricingService
    {
        protected UnitOfWork _unit;
        public PricingService(UnitOfWork unit)
        {
            _unit = unit;
        }

        public Pricing PricingTier { get; set; }

        public async Task<Pricing> GetPricingTierAsync(string tier)
        {
            //gets reserved seats first
            PricingTier = await _unit.Pricings.Get().FirstOrDefaultAsync(x => x.Name == tier);

            return PricingTier;
        }
    }
}
