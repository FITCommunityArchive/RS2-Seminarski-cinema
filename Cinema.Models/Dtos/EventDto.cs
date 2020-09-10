using System;

namespace Cinema.Models.Dtos
{
    public class EventDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Promoter { get; set; }
        public int TypeId { get; set; }
        public EventTypeDto Type { get; set; }
        public int AuthorId { get; set; }
        public ApplicationUserDto Author { get; set; }
    }
}
