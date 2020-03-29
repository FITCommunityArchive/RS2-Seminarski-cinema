using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.DAL.Repository
{
    public class Repository<Entity, Key> : IRepository<Entity, Key> where Entity : class
    {
        protected ApplicationDbContext _context;
        protected DbSet<Entity> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Entity>();
        }

        public virtual IQueryable<Entity> Get() => _dbSet;

        public virtual async Task<Entity> GetAsync(Key id)
        { 
            Entity entity = await _dbSet.FindAsync(id);
            // Exception handling needs to be implemented here:
/*            if (entity == null)
            {
                throw new ArgumentException($"There is no object with id: {id} in the database");
            }*/
            return entity;
        }

        public virtual async Task<List<Entity>> GetAsync(Expression<Func<Entity, bool>> where)
        {
            return await _dbSet.Where(where).ToListAsync();
        }

        public virtual async Task InsertAsync(Entity newEnt)
        {
            await _dbSet.AddAsync(newEnt);
        }

        public virtual async Task UpdateAsync(Entity newEnt, Key id)
        {
            Entity oldEnt = await GetAsync(id);

            if (oldEnt != null)
            {
                _context.Entry(oldEnt).CurrentValues.SetValues(newEnt);
                oldEnt.UpdateAsync(newEnt);
            }
        }

        private void Delete (Entity entity) => _dbSet.Remove(entity);

        public virtual async Task DeleteAsync(Key id)
        {
            Entity entity = await GetAsync(id);

            if (entity != null)
            {
                if (entity.CanDelete())
                {
                    Delete(entity);
                }
                else
                {
                    throw new DependentObjectsPresentException();
                }
            }
        }
    }
}
