﻿using System;
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
using System.Security.Claims;
using Cinema.Web.Mvc.Models;
using System.Net;
using System.Net.Mail;
using QRCoder;
using System.IO;
using System.DrawingCore;
using System.DrawingCore.Imaging;
using System.Text;
using System.Net.Mime;
using Microsoft.AspNetCore.Hosting;
using Cinema.DAL;

namespace Cinema.Web.Mvc.Controllers
{
    public class ReservationsController : BaseController
    {
        private SeatingService _seatingService;
        private PricingService _pricingService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ReservationsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment) : base(context) {
            _seatingService = new SeatingService(_unit);
            _pricingService = new PricingService(_unit);
            _webHostEnvironment = webHostEnvironment;
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


            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);


            var gen = new QRCodeGenerator();
            var data = gen.CreateQrCode("This is a quick test! 123#?", QRCodeGenerator.ECCLevel.H);
            var bmp = new QRCode(data).GetGraphic(10);


            var ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            
            byte[] byteImage = ms.ToArray();

            
            //System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

            //string webRootPath = _webHostEnvironment.WebRootPath;
            ////var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            //img.Save("~/img/test.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            string imageData = "data:image/png;base64," + Convert.ToBase64String(byteImage);
            ViewData["QRCodeData"] = imageData;




            var imageContent = "<img src='" + imageData + "' />";
            var body = "<html><body><p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>"+ imageContent + "</body></html>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("boris.huseincehajic@gmail.com"));  // replace with valid value 
            message.From = new MailAddress("movienet@cloudronin.website");  // replace with valid value
            message.Subject = "Your Ticket for the movie " + currentScreening.Movie.Title;
            message.Body = string.Format(body, "Cinema Website", "info@cloudronin.website", "Thank you for buying ticket from us");
            message.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
            //var imageToInline = new LinkedResource(ms, MediaTypeNames.Image.Jpeg);
            //imageToInline.ContentId = "MyImage";
            //var content = "test";
            //AlternateView alternateView = AlternateView.CreateAlternateViewFromString(content, new ContentType("text/html"));
            //alternateView.LinkedResources.Add(imageToInline);
            //message.AlternateViews.Add(alternateView);

            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "moviesnet@cloudronin.website",  // replace with valid value
                    Password = "ckAjWnOPyEYUQstJ"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp-relay.sendinblue.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }


            return View("Thankyou", reservation);
        }

        public async Task<IActionResult> CancelReservation(int id)
        {

            var reservation = await _unit.Reservations.GetAsync(id);
            reservation.IsCancelled = true;
            _unit.Save();

            return LocalRedirect("/Identity/Account/Manage/Reservations");
            //return View("Index");
        }
    }
}