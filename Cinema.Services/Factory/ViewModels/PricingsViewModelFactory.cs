using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Pricings;
using Cinema.Services.Helpers;

namespace Cinema.Services.Factory.ViewModels
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
                DateCreated = pricing.Created.ToFormattedDate(),
                TimeCreated = pricing.Created.ToFormattedTime(),
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
