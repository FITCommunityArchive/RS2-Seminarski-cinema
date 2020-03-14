using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.DTO.ViewModels.Reservations
{
    public class ReservationIndexVM
    {
        public Hall CurrentHall { get; set; }
        public Screening CurrentScreening { get; set; }
        public List<SeatingModel> ScreeningSeats { get; set; }
        public string ReservedSeats { get; set; }
        public Pricing PricingTier { get; set; }
        [Required]
        public string SelectedSeatsString { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
