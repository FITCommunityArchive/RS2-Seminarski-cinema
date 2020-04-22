using System;
using System.ComponentModel.DataAnnotations;

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
        public string Date { get; set; }
        public string Time { get; set; }
        public string Promoter { get; set; }

        [Display(Name = "Event Type")]
        public MasterModel Type { get; set; }
    }
}
