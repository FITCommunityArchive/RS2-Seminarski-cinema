using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Requests.Reviews
{
    public class ReviewSearchRequest : BaseSearchRequest
    {
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
