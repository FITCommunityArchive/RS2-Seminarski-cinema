using Cinema.Common.Interfaces.Dal;
using Cinema.Domain.Entities;

namespace Cinema.Dal.Repository
{
    public class SeatReservationRepository : Repository<SeatReservation, int>, ISeatReservationRepository
    {

        public SeatReservationRepository(ICinemaDbContext context) : base(context) { }
    }
}
