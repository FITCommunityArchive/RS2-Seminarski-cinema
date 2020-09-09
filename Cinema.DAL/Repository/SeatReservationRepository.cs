using Cinema.Domain.Entities;
using Cinema.Utilities.Interfaces.Dal;

namespace Cinema.Dal.Repository
{
    public class SeatReservationRepository : Repository<SeatReservation, int>, ISeatReservationRepository
    {

        public SeatReservationRepository(ICinemaDbContext context) : base(context) { }
    }
}
