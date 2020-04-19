using System;

namespace Cinema.DTO.ViewModels.Events
{
    public class EventIndexVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IdentityMasterModel Author { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Promoter { get; set; }
        public MasterModel Type { get; set; }
    }
}
