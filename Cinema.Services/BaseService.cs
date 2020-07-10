using AutoMapper;
using Cinema.Dal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {

        protected readonly UnitOfWork _unit;
        protected readonly IMapper _mapper;

        public BaseService(UnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(TSearch search)
        {
            var list = _unit.Movies.Get();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _unit.Movies.GetAsync(id);
            return _mapper.Map<TModel>(entity);
        }
    }
}
