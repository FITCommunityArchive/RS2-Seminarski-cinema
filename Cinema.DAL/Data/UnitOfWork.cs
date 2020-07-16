using Cinema.Dal.Repository;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Utilities.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Dal.Data
{
    /*Legacy of Gigi School of Coding*/
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        

        private bool disposed;
        private Dictionary<string, object> repositories;
        protected ICinemaDbContext _context;

        public UnitOfWork(ICinemaDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose( bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public IRepository<Entity, Key> Repository<Entity,Key>() where Entity : class
        {
            if(repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(Entity).Name;
            if(!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<,>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(Entity),typeof(Key)), _context);
                repositories.Add(type, repositoryInstance);
            }
            return (Repository<Entity, Key>)repositories[type];
        }

        public int Save() => _context.SaveChanges();

        public async Task<int> SaveAsync() { return await _context.SaveChangesAsync(true); }

    }
}
