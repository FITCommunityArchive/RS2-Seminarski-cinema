using Cinema.Dal.Repository;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Utilities.Interfaces.Dal;
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

        public IUserRepository Users => Repository<ApplicationUser, int>() as IUserRepository;
        public IRepository<ApplicationRole, int> Roles => Repository<ApplicationRole, int>();
        public IMovieRepository Movies => Repository<Movie, int>() as IMovieRepository;

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
