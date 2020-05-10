using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Domain.Entities
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            Created = DateTime.Now;
            Deleted = false;
        }
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public bool Deleted { get; set; }
    }
}
