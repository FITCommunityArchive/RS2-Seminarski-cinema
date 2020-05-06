using Cinema.DTO.ModelValidation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;


namespace Cinema.DTO.ViewModels.Screenings
{
    public class ScreeningCreateVM
    {
        public int Id { get; set; }
        public string Movie { get; set; }
        public string Hall { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [Display(Name = "Movie Schedule")]
        [CurrentDate(ErrorMessage = "Date must be after or equal to current date")]
        public DateTime DateAndTime { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [Display(Name = "Movie")]
        public int MovieId { get; set; }
        public SelectList Movies { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [Display(Name = "Hall")]
        public int HallId { get; set; }
        public SelectList Halls { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [Display(Name = "Pricing")]
        public int PricingId { get; set; }
        public SelectList Pricings { get; set; }
    }
}
