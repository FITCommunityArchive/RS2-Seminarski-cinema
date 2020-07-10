using Cinema.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IRepository<Entity, Key>
    {
        IQueryable<Entity> Get();
        Task<Entity> GetAsync(Key id);
        Task<List<Entity>> GetAsync(Expression<Func<Entity, bool>> where);
        Task InsertAsync(Entity entity);
        Task UpdateAsync(Entity entity, Key id);
        Task DeleteAsync(Key id);
        IQueryable<Entity> Sort(IQueryable<Entity> query, SortOrder? sortOrder, string sortProperty);
    }
}
