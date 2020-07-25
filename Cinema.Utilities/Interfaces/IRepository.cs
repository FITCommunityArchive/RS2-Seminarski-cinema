using Cinema.Shared.Enums;
using Cinema.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IRepository<Entity, Key> : IDisposable
    {
        IEnumerable<Entity> Get();
        Task<PagedList<Entity>> GetPagedAsync(Expression<Func<Entity, bool>> where, int pageIndex, int pageSize);
        Task<Entity> GetAsync(Key id);
        Task<IEnumerable<Entity>> GetAsync(Expression<Func<Entity, bool>> where);
        Task InsertAsync(Entity entity);
        Task UpdateAsync(Entity entity, Key id);
        Task DeleteAsync(Key id);
        IQueryable<Entity> Sort(IQueryable<Entity> query, SortOrder? sortOrder, string sortProperty);
    }
}
