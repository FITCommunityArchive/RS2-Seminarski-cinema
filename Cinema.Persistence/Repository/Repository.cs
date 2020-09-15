using Cinema.Common.Interfaces.Dal;
using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Persistence.Repository
{
    public class Repository<Entity, Key> : IRepository<Entity, Key> where Entity : class
    {
        protected ICinemaDbContext _context;
        protected DbSet<Entity> _dbSet;
        private bool _disposed = false;

        public Repository(ICinemaDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Entity>();
        }

        public virtual IEnumerable<Entity> Get() => _dbSet;

        public virtual async Task<Entity> GetAsync(Key id, ICollection<string> includes = null)
        {
            var query = _dbSet.AsQueryable();
            Entity entity;

            if (includes?.Count() > 0)
            {
                query = AddIncludes(query, includes);
                entity = await query.AsQueryable().FirstOrDefaultAsync(GetByIdExpression(id));
            }
            else
            {
                entity = await _dbSet.FindAsync(id);
            }

            return entity;
        }

        public virtual async Task<IEnumerable<Entity>> GetAsync(Expression<Func<Entity, bool>> where)
        {
            return await _dbSet.Where(where).ToListAsync();
        }

        public virtual async Task<IEnumerable<Entity>> GetAsync(Expression<Func<Entity, bool>> where, IList<string> includes)
        {
            var query = _dbSet.AsQueryable();

            if (includes != null || includes.Count > 0)
            {
                query = AddIncludes(query, includes);
            }

            return await query.Where(where).ToListAsync();
        }

        public virtual async Task<IPagedList<Entity>> GetPagedAsync(Expression<Func<Entity, bool>> where, int pageIndex, int pageSize)
        {
            var query = _dbSet.AsQueryable();

            if (where != null)
            {
                query = query.Where(where);
            }

            var pagedList = await ApplyPaginationAsync(query, pageIndex, pageSize);
            return pagedList;
        }

        public async Task<bool> DetachLocal(Expression<Func<Entity, bool>> match)
        {
            Entity local = await Task.Run(() => _dbSet.Where(match).FirstOrDefault());
            if (local != null)
            {
                this._context.Entry(local).State = EntityState.Detached;
                return true;
            }

            return false;
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
                await newEnt.BuildAsync(_context);

                _context.Entry(oldEnt).CurrentValues.SetValues(newEnt);
                oldEnt.Update(newEnt);
            }
        }

        public virtual async Task DeleteAsync(Key id)
        {

            Entity entity = await GetAsync(id);

            if (entity != null)
            {
                Delete(entity);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual Expression<Func<Entity, bool>> GetByIdExpression(Key id)
        {
            throw new NotImplementedException();
        }

        protected virtual IQueryable<Entity> AddIncludes(IQueryable<Entity> query, ICollection<string> includes)
        {
            //Includes format: "User" or "Screening.Pricing"

            foreach (string include in includes)
            {
                query = query.Include(include);
            }

            return query;
        }

        protected virtual async Task<IPagedList<Entity>> ApplyPaginationAsync(IQueryable<Entity> query, int pageIndex, int pageSize, bool returnAll = false)
        {
            if (pageIndex == 0)
            {
                pageIndex = Paging.DEFAULT_PAGE_INDEX;
            }

            var count = query.Count();

            if (returnAll)
            {
                pageSize = count;
            }
            else if (pageSize == 0)
            {
                pageSize = Paging.DEFAULT_PAGE_SIZE;
            }

            var items = await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PagedList<Entity>(items, count, pageIndex, pageSize);
        }

        protected virtual IQueryable<Entity> ApplySorting(IQueryable<Entity> query, ISearchRequest searchRequest)
        {
            throw new NotImplementedException();
        }

        protected virtual Expression<Func<Entity, object>> GetSortExpression(ISearchRequest searchRequest)
        {
            // needs to be implemented in the specific repository
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        #region Private methods

        private void Delete(Entity entity) => _dbSet.Remove(entity);

        #endregion
    }
}
