using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.DTO.ViewModels.Screenings
{
    public class ScreeningIndexVM
    {
        public int Id { get; set; }
        public string Movie { get; set; }
        public string Hall { get; set; }

        [Display(Name = "Pricing")]
        public MasterModel Pricing { get; set; }

        public DateTime DateAndTime { get; set; }
    }
}
