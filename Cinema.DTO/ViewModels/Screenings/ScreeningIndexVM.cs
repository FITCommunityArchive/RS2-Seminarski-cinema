using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
