using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
    public class DtoBase
    {

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
