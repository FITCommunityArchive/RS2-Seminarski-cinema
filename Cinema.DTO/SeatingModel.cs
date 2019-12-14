using Cinema.Domain.Entities;
using System;

namespace Cinema.DTO
{
    public class SeatingModel
    {
        public int OrderNumber { get; set; }
        public virtual MasterModel Seat { get; set; }        
        public bool Reserved { get; set; }
    }
}
