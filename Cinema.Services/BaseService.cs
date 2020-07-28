using AutoMapper;
using Cinema.Models.Requests;
using Cinema.Shared;
using Cinema.Shared.Enums;
using Cinema.Utilities.Interfaces.Services;
using Cinema.Utilities.Interfaces.Dal;
using System.Threading.Tasks;
using Cinema.Shared.Pagination;

namespace Cinema.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch>
        where TDatabase : class
        where TSearch : BaseSearchRequest
    {
        protected IRepository<TDatabase, int> _repo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public BaseService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _repo = _unit.Repository<TDatabase, int>();
            _mapper = mapper;
        }
        public virtual async Task<IPagedList<TModel>> GetPagedAsync(TSearch search)
        {
            var list = await _repo.GetPagedAsync(null, search.PageIndex, search.PageSize);
            var dtoList = PagedList<TModel>.Map<TDatabase>(_mapper, list);

            return dtoList;
        }

        public async virtual Task<TModel> GetByIdAsync(int id)
        {
            var entity = await _repo.GetAsync(id);
            return _mapper.Map<TModel>(entity);
        }
    }
}
