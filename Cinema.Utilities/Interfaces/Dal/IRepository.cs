﻿using Cinema.Shared;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IRepository<Entity, Key> : IDisposable
    {
        IEnumerable<Entity> Get();
        Task<Entity> GetAsync(Key id);
        Task<IEnumerable<Entity>> GetAsync(Expression<Func<Entity, bool>> where);
        Task<IPagedList<Entity>> GetPagedAsync(Expression<Func<Entity, bool>> where, int pageIndex, int pageSize);
        Task InsertAsync(Entity entity);
        Task UpdateAsync(Entity entity, Key id);
        Task DeleteAsync(Key id);
    }
}