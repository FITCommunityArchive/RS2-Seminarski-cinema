using Cinema.Dal.Repository;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Dal.Data
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private bool _disposed;
        private Dictionary<string, object> _repositories;
        protected ICinemaDbContext _context;

        public IRepository<ApplicationUser, string> Users => Repository<ApplicationUser, string>();
        public IRepository<ApplicationRole, string> Roles => Repository<ApplicationRole, string>();
        public IRepository<ApplicationUserRole, string> UserRoles => Repository<ApplicationUserRole, string>();
        public IRepository<Event, int> Events => Repository<Event, int>();
        public IRepository<EventType, int> EventTypes => Repository<EventType, int>();
        public IRepository<Genre, int> Genres => Repository<Genre, int>();
        public IRepository<GenreMovie, int> GenreMovies => Repository<GenreMovie, int>();
        public IRepository<Hall, int> Halls => Repository<Hall, int>();
        public IRepository<Invoice, int> Invoices => Repository<Invoice, int>();
        public IRepository<Movie, int> Movies => Repository<Movie, int>();
        public IRepository<News, int> News => Repository<News, int>();
        public IRepository<NewsType, int> NewsTypes => Repository<NewsType, int>();
        public IRepository<Pricing, int> Pricings => Repository<Pricing, int>();
        public IRepository<Reservation, int> Reservations => Repository<Reservation, int>();
        public IRepository<Review, int> Reviews => Repository<Review, int>();
        public IRepository<Screening, int> Screenings => Repository<Screening, int>();
        public IRepository<Seat, int> Seats => Repository<Seat, int>();
        public IRepository<SeatReservation, int> SeatReservations => Repository<SeatReservation, int>();


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
                var repositoryType = typeof(Repository<,>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(Entity), typeof(Key)), _context);
                _repositories.Add(type, repositoryInstance);
            }
            return (Repository<Entity, Key>)_repositories[type];
        }

        public int Save() => _context.SaveChanges();

        public async Task<int> SaveAsync() { return await _context.SaveChangesAsync(true); }
    }
}
