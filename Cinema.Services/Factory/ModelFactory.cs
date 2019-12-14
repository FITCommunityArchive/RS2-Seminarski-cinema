using Cinema.Domain.Entities;
using Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Factory
{
    public static class ModelFactory
    {
        public static SeatingModel CreateSeating(this Seat seat, bool reserved)
        {
            return new SeatingModel
            {
                Seat = seat.Master(),
                Reserved = reserved
            };
        }
    }
}
