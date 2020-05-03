using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.DTO.ViewModels.Pricings
{
    public class PricingDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [Display(Name = "Date created")]
        public string DateCreated { get; set; }

        [Display(Name = "Time created")]
        public string TimeCreated { get; set; }
    }
}
