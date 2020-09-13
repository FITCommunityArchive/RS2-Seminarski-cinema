using AutoMapper;
using Cinema.Common.Interfaces.Dal;
using Cinema.Common.Interfaces.Services;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.News;
using Cinema.Shared.Pagination;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class NewsService : INewsService
    {
        private readonly IUnitOfWork _unit;
        private readonly INewsRepository _newsRepo;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public NewsService(IUnitOfWork unit, IMapper mapper, IAuthService authService)
        {
            _unit = unit;
            _newsRepo = unit.News;
            _mapper = mapper;
            _authService = authService;
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

        public async Task<NewsDto> InsertAsync(NewsUpsertRequest req)
        {
            var news = _mapper.Map<News>(req);

            int authorId = await _authService.GetCurrentUserIdAsync();
            news.AuthorId = authorId;

            await _newsRepo.InsertAsync(news);

            await _unit.SaveAsync();

            var dto = _mapper.Map<NewsDto>(news);
            return dto;
        }

        public async Task<NewsDto> UpdateAsync(int id, NewsUpsertRequest req)
        {
            News news = _mapper.Map<News>(req);
            news.Id = id;

            await _newsRepo.UpdateAsync(news, id);

            news = await _newsRepo.GetAsync(id);
            await _unit.SaveAsync();

            var dto = _mapper.Map<NewsDto>(news);
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _newsRepo.DeleteAsync(id);
            await _unit.SaveAsync();

            return true;
        }
    }
}
