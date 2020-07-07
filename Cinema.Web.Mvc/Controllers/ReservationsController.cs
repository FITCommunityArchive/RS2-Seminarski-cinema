using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Dto.ViewModels.Reservations;
using Cinema.EmailService;
using Cinema.Services;
using Cinema.Utilities.Constants;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.Controllers
{
    public class ReservationsController : BaseController
    {
        private SeatingService _seatingService;
        private PricingService _pricingService;
        private QRCodeService _qRCodeService;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReservationsController(CinemaDbContext context, IEmailSender emailSender, IWebHostEnvironment webHostEnvironment, IConfiguration configuration) : base(context, configuration)
        {
            _seatingService = new SeatingService(_unit);
            _pricingService = new PricingService(_unit);

            _emailSender = emailSender;
            _webHostEnvironment = webHostEnvironment;

            _qRCodeService = new QRCodeService(_webHostEnvironment);
        }

        [Route("/Reservations/{screeningId:int?}")]
        public async Task<IActionResult> Index(int screeningId, string errorMessage)
        {
            ViewData["successMessage"] = "";
            ViewBag.ErrorMessage = errorMessage;

            var currentScreening = await _unit.Screenings.GetAsync(screeningId);
            var currentHall = currentScreening.Hall;

            var viewModel = new ReservationIndexVM
            {
                CurrentHall = currentHall,
                CurrentScreening = currentScreening,
                ScreeningSeats = _seatingService.GetScreeningSeating(currentScreening),
                ReservedSeats = string.Join(",", _seatingService.ReservedSeats),
                PricingTier = currentScreening.Pricing
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Checkout(int screeningId, int quantity, string selectedSeatsString)
        {
            Screening screening = await _unit.Screenings.GetAsync(screeningId);

            if (screening.DateAndTime < DateTime.UtcNow)
            {
                return RedirectToAction("Index", new { screeningId = screeningId });
            }

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (selectedSeatsString == null)
            {
                return RedirectToAction("Index", new { screeningId = screeningId, errorMessage = ValidationMessages.NO_SEATS_SELECTED });
            }
            else if (screening == null || string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Index", new { screeningId = screeningId, errorMessage = "" });
            }

            var selectedSeats = selectedSeatsString.Split(',').Select(Int32.Parse).ToList();

            Reservation reservation = new Reservation
            {
                User = await _unit.Users.GetAsync(userId),
                Screening = screening,
                IsCancelled = false,
                ReservationCode = Convert.ToString(System.Guid.NewGuid()).Substring(0, 7).ToUpper()
            };

            Invoice invoice = new Invoice
            {
                Reservation = reservation,
                TicketQuantity = quantity,
                OfferTypeId = screening.PricingId
            };

            foreach (int seatNumber in selectedSeats)
            {
                var seat = (await _unit.Seats.GetAsync(x => x.HallId == screening.HallId && x.SeatNumber == seatNumber)).FirstOrDefault();

                if (seat != null && !await _seatingService.IsSeatReservedAsync(seat.Id, screeningId))
                {
                    SeatReservation seatReservation = new SeatReservation
                    {
                        Seat = seat,
                        Reservation = reservation,
                        SeatId = seat.Id
                    };

                    seatReservation.Seat.CreateSeatLabel();

                    await _unit.SeatReservations.InsertAsync(seatReservation);
                }
                else
                {
                    return RedirectToAction("Index", new { screeningId = screeningId, errorMessage = "" });
                }
            }

            _unit.Invoices.SetInvoicePrice(invoice, quantity);
            await _unit.Invoices.InsertAsync(invoice);
            await _unit.Reservations.InsertAsync(reservation);

            await _unit.SaveAsync();

            var imageUri = _qRCodeService.GenerateCode(reservation.ReservationCode);
            var imageUrl = String.Format("data:image/png;base64,{0}", imageUri);

            var attachment = new FormFileCollection();
            var messageContent = "";
            messageContent += "<h3>Your reservation code: " + reservation.ReservationCode + "</h3>";
            messageContent += "<p>You can pick up your movie tickets with your booking number directly from the box office during business hours.</p>";
            messageContent += "<p>Please note that your tickets must be raised no later than 30 minutes before the screening begins, otherwise the computer will cancel them. Please bring your booking confirmation with you.</p>";
            messageContent += "<p>During the evenings and weekends, count on the longer wait.</p>";
            messageContent += "<p>Cancellation: Under \"My Cinema Tickets\" in your membership section, you can print, edit or cancel your reservation at any time. Please sign up for this on our website in the membership section.You will be shown the \"My Cinema Tickets\" category in the upper black section.</p>";
            messageContent += "<p>Information: Discounts are only possible with the appropriate membership card before printing cinema tickets(e.g.Family Movie Club Card, Cineplexx Bonus Card)";
            messageContent += "<h4>Have a great time at our cinema!</h4>";

            using (var stream = System.IO.File.OpenRead("wwwroot/qrr/" + reservation.ReservationCode + ".jpg"))
            {
                var file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
                {
                    Headers = new HeaderDictionary(),
                    ContentType = "image/jpg"
                };
                attachment.Add(file);

                var message = new Message(new string[] { reservation.User.Email }, "Your Ticket for the movie " + screening.Movie.Title, messageContent, attachment);
                await _emailSender.SendEmailAsync(message);
            }

            // when we go live we can just use the path of the image and add it to the image tag and link it directly. That way we don't have to create FormFile and then send the message.

            //var path = _webHostEnvironment.WebRootFileProvider.GetFileInfo("qrr/f9899d012392550227.jpg");
            //var message2 = new Message(new string[] { "boris@cloudronin.com" }, "Your Ticket for the movie " + currentScreening.Movie.Title, "<img src='"+ path+"' />");
            //await _emailSender.SendEmailAsync(message2);

            return RedirectToAction("Thankyou", new { reservationID = reservation.Id });
        }

        [HttpGet, Route("/Reservations/Thankyou")]
        public IActionResult Thankyou(int reservationID)
        {
            var viewModel = _unit.Reservations.Get().Where(x => x.Id == reservationID).FirstOrDefault();
            var qrCodeUri = _qRCodeService.GenerateCode(viewModel.ReservationCode);
            var qrCode = String.Format("data:image/png;base64,{0}", qrCodeUri);
            @ViewData["QRCodeData"] = qrCode;

            return View(viewModel);
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