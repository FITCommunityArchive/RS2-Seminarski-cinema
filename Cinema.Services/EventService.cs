using AutoMapper;
using Cinema.Common.Interfaces.Dal;
using Cinema.Common.Interfaces.Services;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Events;
using Cinema.Shared.Pagination;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class EventService : IEventService
    {
        private readonly IUnitOfWork _unit;
        private readonly IEventRepository _eventRepo;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public EventService(IUnitOfWork unit, IMapper mapper, IAuthService authService)
        {
            _unit = unit;
            _eventRepo = unit.Events;
            _mapper = mapper;
            _authService = authService;
        }

        public async Task<EventDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            var entity = await _eventRepo.GetAsync(id, includes);
            return _mapper.Map<EventDto>(entity);
        }

        public async Task<IPagedList<EventDto>> GetPagedAsync(EventSearchRequest search)
        {
            var list = await _eventRepo.GetPagedAsync(search, search.Title, search.Author, search.Promoter, search.TypeId, search.DateAndTime);
            var dtoList = PagedList<EventDto>.Map<Event>(_mapper, list);

            return dtoList;
        }

        public async Task<EventDto> InsertAsync(EventUpsertRequest req)
        {
            var entity = _mapper.Map<Event>(req);

            int authorId = await _authService.GetCurrentUserIdAsync();
            entity.AuthorId = authorId;

            await _eventRepo.InsertAsync(entity);

            await _unit.SaveAsync();

            var dto = _mapper.Map<EventDto>(entity);
            return dto;
        }

        public async Task<EventDto> UpdateAsync(int id, EventUpsertRequest req)
        {
            Event entity = _mapper.Map<Event>(req);
            entity.Id = id;

            await _eventRepo.UpdateAsync(entity, id);

            entity = await _eventRepo.GetAsync(id);
            await _unit.SaveAsync();

            var dto = _mapper.Map<EventDto>(entity);
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _eventRepo.DeleteAsync(id);
            await _unit.SaveAsync();

            return true;
        }
    }
}
