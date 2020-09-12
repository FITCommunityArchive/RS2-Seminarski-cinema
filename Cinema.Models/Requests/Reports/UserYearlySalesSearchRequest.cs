using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Requests.Reports
{
    public class UserYearlySalesSearchRequest : BaseSearchRequest
    {
        public int? Year { get; set; }
        public int? UserId { get; set; }
        public string UserFullName { get; set; }
    }
}
