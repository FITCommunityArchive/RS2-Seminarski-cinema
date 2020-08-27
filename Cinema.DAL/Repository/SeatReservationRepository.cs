using Cinema.Domain.Entities;
using Cinema.Utilities.Interfaces.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Dal.Repository
{
    public class SeatReservationRepository : Repository<SeatReservation,int>, ISeatReservationRepository
    {

        public SeatReservationRepository(ICinemaDbContext context) : base(context) { }


        public async Task<bool> DeleteReservationReferences(List<Reservation> reservations)
        {

            foreach(Reservation r in reservations)
            {
                var item = _context.SeatReservations.Where(x => x.ReservationId == r.Id).FirstOrDefault();
                if(item != null) { 
                    await DeleteAsync(item.Id);
                }
            }
            
            return true;
        }
    }
}
