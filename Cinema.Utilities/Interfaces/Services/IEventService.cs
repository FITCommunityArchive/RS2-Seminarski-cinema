using Cinema.Models.Dtos;
using Cinema.Models.Requests.Events;
using Cinema.Models.Requests.News;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IEventService : ICRUDService<EventDto, EventSearchRequest, EventUpsertRequest, EventUpsertRequest>
    {
    }
}
