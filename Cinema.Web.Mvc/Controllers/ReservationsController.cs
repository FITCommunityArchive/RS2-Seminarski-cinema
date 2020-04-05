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
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Cinema.Web.Mvc.Controllers
{
    public class ReservationsController : BaseController
    {
        private SeatingService _seatingService;
        private PricingService _pricingService;
        private QRCodeService _qRCodeService;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ReservationsController(ApplicationDbContext context, IEmailSender emailSender, IWebHostEnvironment webHostEnvironment) : base(context) {
            _seatingService = new SeatingService(_unit);
            _pricingService = new PricingService(_unit);
            
            _emailSender = emailSender;
            _webHostEnvironment = webHostEnvironment;

            _qRCodeService = new QRCodeService(_webHostEnvironment);
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
                IsCancelled = false,
                ReservationCode = Convert.ToString(System.Guid.NewGuid()).Substring(0, 7).ToUpper()
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

            var imageUri = _qRCodeService.GenerateCode(reservation.ReservationCode);
            var imageUrl = String.Format("data:image/png;base64,{0}", imageUri);

            @ViewData["QRCodeData"] = imageUrl;

            var attachment = new FormFileCollection();
            var messageContent = "";
            messageContent += "<h3>Your reservation code: " + reservation.ReservationCode + "</h3>"; 
            messageContent += "<p>You can pick up your movie tickets with your booking number directly from the box office during business hours.</p>";
            messageContent += "<p>Please note that your tickets must be raised no later than 30 minutes before the screening begins, otherwise the computer will cancel them. Please bring your booking confirmation with you.</p>";
            messageContent += "<p>During the evenings and weekends, count on the longer wait.</p>";
            messageContent += "<p>Cancellation: Under \"My Cinema Tickets\" in your membership section, you can print, edit or cancel your reservation at any time. Please sign up for this on our website in the membership section.You will be shown the \"My Cinema Tickets\" category in the upper black section.</p>";
            messageContent += "<p>Information: Discounts are only possible with the appropriate membership card before printing cinema tickets(e.g.Family Movie Club Card, Cineplexx Bonus Card)";
            messageContent += "<h4>Have a great time at our cinema!</h4>"; 

            using (var stream = System.IO.File.OpenRead("wwwroot/qrr/"+reservation.ReservationCode+".jpg"))
            {
                var file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
                {
                    Headers = new HeaderDictionary(),
                    ContentType = "image/jpg"
                };
                attachment.Add(file);

                var message = new Message(new string[] { "boris@cloudronin.com" }, "Your Ticket for the movie " + currentScreening.Movie.Title, messageContent, attachment);
                await _emailSender.SendEmailAsync(message);
            }

            // when we go live we can just use the path of the image and add it to the image tag and link it directly. That way we don't have to create FormFile and then send the message.

            //var path = _webHostEnvironment.WebRootFileProvider.GetFileInfo("qrr/f9899d012392550227.jpg");
            //var message2 = new Message(new string[] { "boris@cloudronin.com" }, "Your Ticket for the movie " + currentScreening.Movie.Title, "<img src='"+ path+"' />");
            //await _emailSender.SendEmailAsync(message2);

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