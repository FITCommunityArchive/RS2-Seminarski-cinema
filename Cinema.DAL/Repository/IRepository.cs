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
        Entity Get(Key id);
        IList<Entity> Get(Func<Entity, bool> where);
        void Insert(Entity entity);
        void Update(Entity entity, Key id);
        void Delete(Entity entity);
        void Delete(Key id);
        Task<IList<Entity>> GetAsync();
        Task<Entity> GetAsync(Key id);
        Task<IList<Entity>> GetAsync(Expression<Func<Entity, bool>> where);
        Task InsertAsync(Entity entity);
        Task UpdateAsync(Entity entity, Key id);
        void DeleteAsync(Entity entity);
        Task DeleteAsync(Key id);
    }
}
