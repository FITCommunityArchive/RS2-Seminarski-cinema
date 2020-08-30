using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Requests.Pricing
{
    public class PricingSearchRequest : BaseSearchRequest
    {
        public string searchTerm { get; set; }
    }
}
