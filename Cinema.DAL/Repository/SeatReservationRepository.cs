using Cinema.Domain.Entities;
using Cinema.Common.Interfaces.Dal;

namespace Cinema.Dal.Repository
{
    public class SeatReservationRepository : Repository<SeatReservation, int>, ISeatReservationRepository
    {

        public SeatReservationRepository(ICinemaDbContext context) : base(context) { }
    }
}
