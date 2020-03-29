using Cinema.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Repository
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
