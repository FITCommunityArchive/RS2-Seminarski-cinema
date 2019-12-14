using Cinema.Domain.Entities;
using Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Factory
{
    public static class MasterModelFactory
    {
        public static MasterModel Master(this Seat seat)
        {
            return new MasterModel
            {
                Id = seat.Id,                
                Name = seat.Label
            };
        }
    }
}
