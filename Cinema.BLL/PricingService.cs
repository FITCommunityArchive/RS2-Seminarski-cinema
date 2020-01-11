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
        protected ApplicationDbContext _context;
        public PricingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Pricing PricingTier { get; set; }

        public Pricing GetPricingTier(string tier)
        {
            //gets reserved seats first
            PricingTier = _context.Pricing.FirstOrDefault(x => x.Name == tier);

            return PricingTier;
        }
    }
}
