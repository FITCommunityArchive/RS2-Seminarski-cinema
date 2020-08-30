using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Requests.Pricing
{
    public class PricingUpsertRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
