using AutoMapper;
using Cinema.Utilities.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {

        protected readonly IRepository<TDatabase, int> _repo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public BaseService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _repo = _unit.Repository<TDatabase, int>();
            _mapper = mapper;
        }
        public virtual List<TModel> Get(TSearch search)
        {
            var list = _repo.Get();
            return _mapper.Map<List<TModel>>(list);
        }

        public async virtual Task<TModel> GetById(int id)
        {
            var entity = await _repo.GetAsync(id);
            return _mapper.Map<TModel>(entity);
        }
    }
}
