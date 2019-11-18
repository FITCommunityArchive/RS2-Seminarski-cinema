using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Domain.Entities
{
    public class BaseClass
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
