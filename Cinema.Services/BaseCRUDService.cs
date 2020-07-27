using AutoMapper;
using Cinema.Models.Requests;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate>
        where TDatabase : class
        where TSearch : BaseSearchRequest
    {
        public BaseCRUDService(IUnitOfWork unit, IMapper mapper) : base(unit, mapper)
        {
        }

        public virtual async Task<TModel> Insert(TInsert req)
        {
            var entity = _mapper.Map<TDatabase>(req);

            await _repo.InsertAsync(entity);
            _unit.Save();

            return _mapper.Map<TModel>(entity);
        }

        public async virtual Task<TModel> Update(int id, TUpdate req)
        {
            var entity = await _repo.GetAsync(id);

            await _repo.UpdateAsync(entity, id);

            _mapper.Map(req, entity);

            _unit.Save();

            return _mapper.Map<TModel>(entity);
        }
    }
}
