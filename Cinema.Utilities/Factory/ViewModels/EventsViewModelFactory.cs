using Cinema.Domain.Entities;
using Cinema.Models.ViewModels.Events;
using Cinema.Shared.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cinema.Utilities.Factory.ViewModels
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
                Date = eventEntity.DateAndTime.ToFormattedDate(),
                Time = eventEntity.DateAndTime.ToFormattedTime(),
                Description = eventEntity.Description.Truncate(),
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
                Date = eventEntity.DateAndTime.ToFormattedDate(),
                Time = eventEntity.DateAndTime.ToFormattedTime(),
                Description = eventEntity.Description,
                Image = eventEntity.Image,
                Promoter = eventEntity.Promoter,
                Title = eventEntity.Title,
                Type = eventEntity.Type.CreateMaster()
            };
        }

        public static EventCreateVM ToCreateVM(this Event eventEntity, SelectList eventTypes)
        {
            return new EventCreateVM
            {
                Id = eventEntity.Id,
                DateAndTime = eventEntity.DateAndTime,
                Description = eventEntity.Description,
                Image = eventEntity.Image,
                Promoter = eventEntity.Promoter,
                Title = eventEntity.Title,
                EventTypeId = eventEntity.TypeId,
                EventTypes = eventTypes,
                AuthorId = eventEntity.AuthorId
            };
        }
    }
}
