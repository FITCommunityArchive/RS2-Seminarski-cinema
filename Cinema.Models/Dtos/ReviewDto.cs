using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Dtos
{
    public class ReviewDto
    {
        public string Text { get; set; }
        public int Rating { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
    }
}
