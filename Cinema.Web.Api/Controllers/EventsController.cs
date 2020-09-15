using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Events;

namespace Cinema.Web.Api.Controllers
{
    public class EventsController : BaseCRUDController<EventDto, EventSearchRequest, EventUpsertRequest, EventUpsertRequest>
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService service) : base(service)
        {
            _eventService = service;
        }
    }
}
