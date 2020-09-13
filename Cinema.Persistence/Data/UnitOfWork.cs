using Cinema.Common.Interfaces.Dal;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Persistence.Data
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private bool _disposed;
        private Dictionary<string, object> _repositories;
        protected ICinemaDbContext _context;

        public IUserRepository Users => Repository<ApplicationUser, int>() as IUserRepository;
        public IRepository<ApplicationRole, int> Roles => Repository<ApplicationRole, int>();
        public IMovieRepository Movies => Repository<Movie, int>() as IMovieRepository;
        public IScreeningRepository Screenings => Repository<Screening, int>() as IScreeningRepository;
        public INewsRepository News => Repository<News, int>() as INewsRepository;
        public IEventRepository Events => Repository<Event, int>() as IEventRepository;
        public IReservationRepository Reservations => Repository<Reservation, int>() as IReservationRepository;
        public IReviewRepository Reviews => Repository<Review, int>() as IReviewRepository;
        public ISeatReservationRepository SeatReservations => Repository<SeatReservation, int>() as ISeatReservationRepository;

        public UnitOfWork(ICinemaDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public IRepository<Entity, Key> Repository<Entity, Key>() where Entity : class
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<string, object>();
            }

            var type = typeof(Entity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryInstance = CreateRepositoryInstance<Entity, Key>(type);
                _repositories.Add(type, repositoryInstance);
            }
            return (IRepository<Entity, Key>)_repositories[type];
        }

        private IRepository<Entity, Key> CreateRepositoryInstance<Entity, Key>(string assemblyTypeName) where Entity : class
        {
            switch (assemblyTypeName)
            {
                case nameof(Movie):
                    return (IRepository<Entity, Key>)new MovieRepository(_context);
                case nameof(ApplicationUser):
                    return (IRepository<Entity, Key>)new UserRepository(_context);
                case nameof(Screening):
                    return (IRepository<Entity, Key>)new ScreeningRepository(_context);
                case nameof(Reservation):
                    return (IRepository<Entity, Key>)new ReservationRepository(_context);
                case nameof(SeatReservation):
                    return (IRepository<Entity, Key>)new SeatReservationRepository(_context);
                case nameof(Review):
                    return (IRepository<Entity, Key>)new ReviewRepository(_context);
                case nameof(Domain.Entities.News):
                    return (IRepository<Entity, Key>)new NewsRepository(_context);
                case nameof(Event):
                    return (IRepository<Entity, Key>)new EventRepository(_context);
                default:
                    {
                        var repositoryType = typeof(Repository<,>);
                        return (IRepository<Entity, Key>)Activator.CreateInstance(repositoryType.MakeGenericType(typeof(Entity), typeof(Key)), _context);
                    }
            }
        }

        public int Save() => _context.SaveChanges();

        public async Task<int> SaveAsync() { return await _context.SaveChangesAsync(true); }
    }
}
