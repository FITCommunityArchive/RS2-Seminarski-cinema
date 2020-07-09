using AutoMapper;
using Cinema.Dal.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(CinemaDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(TInsert req)
        {
            var entity = _mapper.Map<TDatabase>(req);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate req)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(req, entity);

            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
    }
}
