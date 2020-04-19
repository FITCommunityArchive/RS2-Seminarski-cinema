using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Events;
using System;
using System.Collections.Generic;
using System.Text;

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
                Description = eventEntity.Description,
                Image = eventEntity.Image,
                Promoter = eventEntity.Promoter,
                Title = eventEntity.Title,
                Type = eventEntity.Type.CreateMaster()
            };
        }
    }
}
