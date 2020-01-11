﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.DAL.Data;
using Cinema.BLL;

namespace Cinema.Web.Pages.ReservationTickets
{
    public class IndexModel : CinemaPageModel
    {
        private SeatingService _seatingService;
        private PricingService _pricingService;

        public IndexModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context)
        {
            _seatingService = new SeatingService(unit);
            _pricingService = new PricingService(unit);
        }

        public Hall CurrentHall { get; set; }
        public Screening CurrentScreening { get; set; }
        public List<SeatingModel> ScreeningSeats { get; set; }
        public string ReservedSeats { get; set; }
        public Pricing PricingTier { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, long date)
        {
            var screeningDate = new DateTime(date);
            CurrentHall = await unit.Halls.GetAsync(id);

            CurrentScreening = CurrentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate);

            //CurrentScreening = _context.Halls.FirstOrDefault(x => x.Id == id).Screenings
                //.FirstOrDefault(x => x.DateAndTime == ScreeningDate);

            ScreeningSeats = _seatingService.GetScreeningSeating(CurrentScreening);

            ReservedSeats = string.Join(",", _seatingService.ReservedSeats);
            PricingTier = _pricingService.GetPricingTier("Premiere");


            return Page();
        }
    }
}