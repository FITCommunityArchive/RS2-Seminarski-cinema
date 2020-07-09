using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models.ViewModels.Events
{
    public class EventDetailsVM
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


        [Display(Name = "Event type")]
        public MasterModel Type { get; set; }
    }
}
