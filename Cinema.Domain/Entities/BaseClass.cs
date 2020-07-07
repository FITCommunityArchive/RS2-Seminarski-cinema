using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Domain.Entities
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }

        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
