using Cinema.Domain.Entities;
using Cinema.Models.SpecificModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models.ViewModels.Reservations
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
