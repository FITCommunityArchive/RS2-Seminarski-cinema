using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Movies;
using Cinema.Services.Factory;
using Cinema.Services.Helpers;
using Microsoft.EntityFrameworkCore;
using Cinema.BLL;
using Cinema.DTO.ViewModels.Reservations;

namespace Cinema.Web.Mvc.Controllers
{
    public class ReservationsController : BaseController
    {
        private SeatingService _seatingService;
        private PricingService _pricingService;
        public ReservationsController(ApplicationDbContext context) : base(context) {
            _seatingService = new SeatingService(_unit);
            _pricingService = new PricingService(_unit);
        }
        [Route("Reservations/{id:int?}/{date:long?}")]
        public IActionResult Index(int id, long date)
        {
            var screeningDate = new DateTime(date);
            var currentHall = _unit.Halls.Get(id);
            var currentScreening = currentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate);
            var viewModel = new ReservationIndexVM
            {
                CurrentHall = _unit.Halls.Get(id),
                CurrentScreening = currentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate),
                ScreeningSeats = _seatingService.GetScreeningSeating(currentScreening),
                ReservedSeats = string.Join(",", _seatingService.ReservedSeats),
                PricingTier = _pricingService.GetPricingTier("Premiere")
            };

            return View(viewModel);
        }
    }
}