using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Events;
using Cinema.Services.Helpers;

namespace Cinema.Services.Factory.ViewModels
{
    public static class EventsViewModelFactory
    {
        public static EventIndexVM ToIndexVM(this Event eventEntity)
        {
            return new EventIndexVM
            {
                Id = eventEntity.Id,
                Author = eventEntity.Author.CreateMaster(),
                DateAndTime = eventEntity.DateAndTime,
                Date = eventEntity.DateAndTime.ToString("dd.MM.yyyy"),
                Time = eventEntity.DateAndTime.ToString("t"),
                Description = eventEntity.Description.LimitStringLength(),
                Image = eventEntity.Image,
                Promoter = eventEntity.Promoter,
                Title = eventEntity.Title,
                Type = eventEntity.Type.CreateMaster()
            };
        }

        public static EventDetailsVM ToDetailsVM(this Event eventEntity)
        {
            return new EventDetailsVM
            {
                Id = eventEntity.Id,
                Author = eventEntity.Author.CreateMaster(),
                DateAndTime = eventEntity.DateAndTime,
                Date = eventEntity.DateAndTime.ToString("dd.MM.yyyy"),
                Time = eventEntity.DateAndTime.ToString("t"),
                Description = eventEntity.Description,
                Image = eventEntity.Image,
                Promoter = eventEntity.Promoter,
                Title = eventEntity.Title,
                Type = eventEntity.Type.CreateMaster()
            };
        }
    }
}
