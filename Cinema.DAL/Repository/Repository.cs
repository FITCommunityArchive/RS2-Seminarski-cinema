using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Exceptions;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Dal.Repository
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

        public virtual async Task<Entity> GetAsync(Key id)
        {
            Entity entity = await _dbSet.FindAsync(id);
            return entity;
        }

        public virtual async Task<IEnumerable<Entity>> GetAsync(Expression<Func<Entity, bool>> where)
        {
            return await _dbSet.AsNoTracking().Where(where).ToListAsync();
        }

        public virtual async Task<IPagedList<Entity>> GetPagedAsync(Expression<Func<Entity, bool>> where, int pageIndex, int pageSize)
        {
            var query = _dbSet.AsNoTracking();

            if (where != null)
            {
                query = query.Where(where);
            }

            var pagedList = await ApplyPaginationAsync(query, pageIndex, pageSize);
            return pagedList;
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
                //await newEnt.BuildAsync(_context);

                // Update operations should be handled outside of repositories
                //_context.Entry(oldEnt).CurrentValues.SetValues(newEnt);
                oldEnt.Update(newEnt);
            }
        }

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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual async Task<IPagedList<Entity>> ApplyPaginationAsync(IQueryable<Entity> query, int pageIndex, int pageSize)
        {
            if (pageIndex == 0)
            {
                pageIndex = Paging.DEFAULT_PAGE_INDEX;
            }

            if (pageSize == 0)
            {
                pageSize = Paging.DEFAULT_PAGE_SIZE;
            }

            var count = query.Count();
            var items = await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PagedList<Entity>(items, count, pageIndex, pageSize);
        }

        protected virtual IQueryable<Entity> ApplySorting(IQueryable<Entity> query, ISearchRequest searchRequest)
        {
            throw new NotImplementedException();
        }

        protected virtual Expression<Func<Entity, object>> GetSortExpression(ISearchRequest searchRequest)
        {
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
