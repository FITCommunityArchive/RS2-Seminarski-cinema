using AutoMapper;
using Cinema.Dal.Data;
using Cinema.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(IUnitOfWork unit,IMapper mapper) : base(unit,mapper)
        {
        }

        //public virtual TModel Insert(TInsert req)
        //{
        //    var entity = _mapper.Map<TDatabase>(req);

        //    _unit.Set<TDatabase>().Add(entity);
        //    _unit.SaveChanges();

        //    return _mapper.Map<TModel>(entity);
        //}

        //public virtual TModel Update(int id, TUpdate req)
        //{
        //    var entity = _unit.Set<TDatabase>().Find(id);

        //    _unit.Set<TDatabase>().Attach(entity);
        //    _unit.Set<TDatabase>().Update(entity);

        //    _mapper.Map(req, entity);

        //    _unit.SaveChanges();

        //    return _mapper.Map<TModel>(entity);
        //}
    }
}
