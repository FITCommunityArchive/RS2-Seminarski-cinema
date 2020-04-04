using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.BLL;
using Cinema.DTO.ViewModels.Reservations;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using EmailService;

namespace Cinema.Web.Mvc.Controllers
{
    public class ReservationsController : BaseController
    {
        private SeatingService _seatingService;
        private PricingService _pricingService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly IEmailSender _emailSender;
        public ReservationsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, IEmailSender emailSender) : base(context) {
            _seatingService = new SeatingService(_unit);
            _pricingService = new PricingService(_unit);
            _webHostEnvironment = webHostEnvironment;
            _emailSender = emailSender;
        }

        [Route("/Reservations/{id:int?}/{date:long?}")]
        public async Task<IActionResult> Index(int id, long date)
        {

            ViewData["successMessage"] = "";
            ViewData["errorMessage"] = "";

            var screeningDate = new DateTime(date);
            var currentHall = await _unit.Halls.GetAsync(id);
            var currentScreening = currentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate);
            var viewModel = new ReservationIndexVM
            {
                CurrentHall = await _unit.Halls.GetAsync(id),
                CurrentScreening = currentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate),
                ScreeningSeats = _seatingService.GetScreeningSeating(currentScreening),
                ReservedSeats = string.Join(",", _seatingService.ReservedSeats),
                PricingTier = await _pricingService.GetPricingTierAsync("Premiere")
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Checkout(int id, long date, decimal price, int quantity, string SelectedSeatsString)
        {

            if (SelectedSeatsString == null)
            {
                ViewData["errorMessage"] = "You haven't picked your seats.";
                return RedirectToAction("Index", new { id = id, date = date });
            }

            var selectedSeats = SelectedSeatsString.Split(',').Select(Int32.Parse).ToList();
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var screeningDate = new DateTime(date);
            var currentHall = await _unit.Halls.GetAsync(id);
            var currentScreening = currentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate);

            var invoice = new Invoice
            {
                Price = price,
                TicketQuantity = quantity,
                OfferTypeId = 1 //for now hardcode offer type ID to premiere as we get that on the beginning of the checkout.
            };

            Reservation reservation = new Reservation
            {
                User = await _unit.Users.GetAsync(userID),
                Screening = currentScreening,
                IsCancelled = false
            };
            invoice.ReservationId = reservation.Id;
            reservation.Invoices.Add(invoice);

            await _unit.Reservations.InsertAsync(reservation);

            _unit.Save();

            foreach (int seatNumber in selectedSeats)
            {
                var getSeatByNumber = _unit.Seats.Get().Where(x => x.SeatNumber == seatNumber && x.HallId == id).FirstOrDefault();
                SeatReservation seatReservation = new SeatReservation
                {
                    Seat = getSeatByNumber,
                    Reservation = reservation,
                    SeatId = getSeatByNumber.Id,
                    ReservationId = reservation.Id
                };

                seatReservation.Seat.CreateSeatLabel();

                await _unit.SeatReservations.InsertAsync(seatReservation);
            }

            _unit.Save();

            var imageByteCode = new QRCoderController().GenerateCode("This is how we do.");
            var imageUrl = String.Format("data:image/png;base64,{0}", Convert.ToBase64String(imageByteCode));
            var image = "<img src='" + imageUrl + "' />";

            @ViewData["QRCodeData"] = imageUrl;

            var message = new Message(new string[] { "boris@cloudronin.com" }, "Your Ticket for the movie " + currentScreening.Movie.Title, image);
            await _emailSender.SendEmailAsync(message);


            return View("Thankyou", reservation);
        }

        public async Task<IActionResult> CancelReservation(int id)
        {

            var reservation = await _unit.Reservations.GetAsync(id);
            reservation.IsCancelled = true;
            _unit.Save();

            return LocalRedirect("/Identity/Account/Manage/Reservations");
        }
    }
}