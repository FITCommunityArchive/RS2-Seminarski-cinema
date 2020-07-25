using AutoMapper;

namespace Cinema.Shared.Helpers
{
    public class MapperFactory<TInput, TOutput> where TInput : class where TOutput : class
    {
        private readonly IMapper _mapper;
        public MapperFactory(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PagedList<TOutput> ToPagedList(PagedList<TInput> entityList)
        {
            var result = _mapper.Map<PagedList<TOutput>>(entityList);

            return result;
        }
    }
}
