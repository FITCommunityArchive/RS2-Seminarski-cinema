using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface ISeatReservationRepository : IRepository<SeatReservation,int>
    {
    }
}
