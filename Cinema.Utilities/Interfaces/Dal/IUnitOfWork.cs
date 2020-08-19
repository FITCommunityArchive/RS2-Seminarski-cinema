using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IUnitOfWork
    {
        public IUserRepository Users => Repository<ApplicationUser, string>() as IUserRepository;
        public IRepository<ApplicationRole, string> Roles => Repository<ApplicationRole, string>();
        public IMovieRepository Movies => Repository<Movie, int>() as IMovieRepository;
        public IScreeningRepository Screenings => Repository<Screening, int>() as IScreeningRepository;
        public IReservationRepository Reservations => Repository<Reservation, int>() as IReservationRepository;

        IRepository<Entity, Key> Repository<Entity, Key>() where Entity : class;


        int Save();

        Task<int> SaveAsync();
    }
}
