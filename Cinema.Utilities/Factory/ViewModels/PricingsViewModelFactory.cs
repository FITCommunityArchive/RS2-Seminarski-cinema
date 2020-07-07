using Cinema.Domain.Entities;
using Cinema.Models.ViewModels.Pricings;
using Cinema.Utilities.Helpers;

namespace Cinema.Utilities.Factory.ViewModels
{
    public static class PricingsViewModelFactory
    {
        public static PricingIndexVM ToIndexVM(this Pricing pricing)
        {
            return new PricingIndexVM
            {
                Id = pricing.Id,
                Name = pricing.Name,
                Price = pricing.Price,
                DateCreated = pricing.CreatedAt.ToFormattedDate(),
                TimeCreated = pricing.CreatedAt.ToFormattedTime(),
            };
        }

        public static PricingDetailsVM ToDetailsVM(this Pricing pricing)
        {
            return new PricingDetailsVM
            {
                Id = pricing.Id,
                Name = pricing.Name,
                Price = pricing.Price
            };
        }

        public static PricingCreateVM ToCreateVM(this Pricing pricing)
        {
            return new PricingCreateVM
            {
                Id = pricing.Id,
                Name = pricing.Name,
                Price = pricing.Price
            };
        }
    }
}
