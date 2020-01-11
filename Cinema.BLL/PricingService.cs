using System;
using System.Collections.Generic;
using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Cinema.Services.Factory;
using Cinema.DAL.Data;
using System.Linq;

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

        public Pricing GetPricingTier(string tier)
        {
            //gets reserved seats first
            PricingTier = _unit.Pricings.Get().FirstOrDefault(x => x.Name == tier);

            return PricingTier;
        }
    }
}
