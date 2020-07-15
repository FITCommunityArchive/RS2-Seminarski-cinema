using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using System;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Entity, Key> Repository<Entity, Key>() where Entity : class;

        int Save();

        Task<int> SaveAsync();
    }
}
