using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Repository
{
    public class IdentityRepository<Entity> : IIdentityRepository<Entity> where Entity : class
    {
        protected ApplicationDbContext _context;
        protected DbSet<Entity> _dbSet;

        public IdentityRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Entity>();
        }


        public virtual IQueryable<Entity> Get() => _dbSet;

        public virtual IList<Entity> Get(Func<Entity, bool> where) => Get().Where(where).ToList();

        public virtual Entity Get(string id)
        {
            Entity entity = _dbSet.Find(id);
            if (entity == null)
                throw new ArgumentException($"There is no object with id: {id} in the database");
            return entity;
        }

        public virtual void Insert(Entity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(Entity entity, string id)
        {
            _context.Update(entity);
        }

        public void Delete(Entity entity) => _dbSet.Remove(entity);

        public virtual void Delete(string id)
        {
            Entity old = Get(id);
            Delete(old);
        }

        public async Task<IList<Entity>> GetAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Entity> GetAsync(string id)
        {
            Entity entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentException($"There is no object with id: {id} in the database");
            }
            return entity;
        }

        public async Task<IList<Entity>> GetAsync(Expression<Func<Entity, bool>> where)
        {
            return await _dbSet.Where(where).ToListAsync();
        }

        public async Task InsertAsync(Entity newEnt)
        {
            await _dbSet.AddAsync(newEnt);
        }

        public async Task UpdateAsync(Entity newEnt, string id)
        {
            Entity oldEnt = await GetAsync(id);
            if (oldEnt != null)
            {
                if (typeof(Entity) == typeof(User)) (newEnt as User).Password = (oldEnt as User).Password;
                _context.Entry(oldEnt).CurrentValues.SetValues(newEnt);
            }
        }

        public void DeleteAsync(Entity entity) => _dbSet.Remove(entity);

        public async Task DeleteAsync(string id)
        {
            Entity entity = await GetAsync(id);
            if (entity != null) Delete(entity);
        }
    }
}
