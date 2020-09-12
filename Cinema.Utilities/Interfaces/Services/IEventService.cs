using Cinema.Models.Dtos;
using Cinema.Models.Requests.Events;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IEventService : ICRUDService<EventDto, EventSearchRequest, EventUpsertRequest, EventUpsertRequest>
    {
    }
}
