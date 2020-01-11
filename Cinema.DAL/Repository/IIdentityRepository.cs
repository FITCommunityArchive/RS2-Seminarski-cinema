using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Repository
{
    public interface IIdentityRepository<Entity>
    {
        IQueryable<Entity> Get();
        Entity Get(string id);
        IList<Entity> Get(Func<Entity, bool> where);
        void Insert(Entity entity);
        void Update(Entity entity, string id);
        void Delete(Entity entity);
        void Delete(string id);
        Task<IList<Entity>> GetAsync();
        Task<Entity> GetAsync(string id);
        Task<IList<Entity>> GetAsync(Expression<Func<Entity, bool>> where);
        Task InsertAsync(Entity entity);
        Task UpdateAsync(Entity entity, string id);
        void DeleteAsync(Entity entity);
        Task DeleteAsync(string id);
    }
}
