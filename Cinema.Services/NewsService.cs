using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.News;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepo;
        private readonly IMapper _mapper;

        public NewsService(IUnitOfWork unit, IMapper mapper)
        {
            _newsRepo = unit.News;
            _mapper = mapper;
        }

        public async Task<NewsDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            var entity = await _newsRepo.GetAsync(id, includes);
            return _mapper.Map<NewsDto>(entity);
        }

        public async Task<IPagedList<NewsDto>> GetPagedAsync(NewsSearchRequest search)
        {
            var list = await _newsRepo.GetPagedAsync(search, search.Title, search.Author, search.TypeId);
            var dtoList = PagedList<NewsDto>.Map<News>(_mapper, list);

            return dtoList;
        }

        public Task<NewsDto> InsertAsync(NewsUpsertRequest req)
        {
            throw new System.NotImplementedException();
        }

        public Task<NewsDto> UpdateAsync(int id, NewsUpsertRequest req)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
