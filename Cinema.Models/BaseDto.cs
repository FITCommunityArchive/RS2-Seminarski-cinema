using System;

namespace Cinema.Models
{
    public class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
