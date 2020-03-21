using System;
using System.Collections.Generic;
using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Cinema.Services.Factory;
using Cinema.DAL.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL
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
