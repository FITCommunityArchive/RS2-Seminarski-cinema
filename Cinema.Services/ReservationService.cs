using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.EmailService;
using Cinema.Models.Dtos;
using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reservations;
using Cinema.Shared.Constants;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Common.Exceptions;
using Cinema.Common.Interfaces.Dal;
using Cinema.Common.Interfaces.Integrations;
using Cinema.Common.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class ReservationService : IReservationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IScreeningService _screeningService;
        private readonly IConfiguration _configuration;
        private readonly IAuthService _authService;
        private readonly IQRCodeService _qRCodeService;
        private readonly IEmailSender _emailSender;
        protected readonly IReservationRepository _reservationRepo;
        protected readonly IScreeningRepository _screeningRepo;
        protected readonly IUserRepository _userRepo;
        protected readonly IRepository<Seat, int> _seatRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public ReservationService(IUnitOfWork unit, IMapper mapper, UserManager<ApplicationUser> userManager, IScreeningService screeningService, IConfiguration configuration, IAuthService authService, IQRCodeService qRCodeService, IEmailSender emailSender)
        {
            _unit = unit;
            _mapper = mapper;
            _reservationRepo = unit.Reservations;
            _screeningRepo = unit.Screenings;
            _userRepo = unit.Users;
            _seatRepo = unit.Repository<Seat, int>();
            _userManager = userManager;
            _screeningService = screeningService;
            _configuration = configuration;
            _authService = authService;
            _qRCodeService = qRCodeService;
            _emailSender = emailSender;
        }

        public Task<ReservationDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IPagedList<ReservationDto>> GetPagedAsync(ReservationSearchRequest search)
        {
            var list = await _reservationRepo.GetPagedAsync(search, search.ReservationId, search.Movie, search.CustomerFullName, search.Price, search.CreatedAt, search.Status);
            var dtoList = PagedList<ReservationDto>.Map<Reservation>(_mapper, list);

            foreach (var reservation in dtoList.Data)
            {
                reservation.Status = GetReservationStatus(reservation);
            }

            return dtoList;
        }

        public async Task<ReservationDto> InsertAsync(ReservationUpsertRequest req)
        {
            List<string> screeningIncludes = new List<string> { nameof(Screening.Pricing), nameof(Screening.Movie) };
            Screening screening = await _unit.Screenings.GetAsync(req.ScreeningId, screeningIncludes);

            ApplicationUserDto currentUser = await _authService.GetCurrentUserAsync();

            IEnumerable<int> selectedSeatIds = req.SelectedSeats;

            await ValidateRequestAsync(req, screening, selectedSeatIds);

            Reservation reservation = new Reservation
            {
                UserId = currentUser.Id,
                Screening = screening,
                IsCancelled = false,
                TicketQuantity = req.SelectedSeats.Count,
                ReservationCode = GenerateReservationCode()
            };

            Invoice invoice = CreateInvoice(reservation, screening.PricingId, req.SelectedSeats.Count);

            foreach (var selectedSeatId in req.SelectedSeats)
            {
                SeatReservation seatReservation = new SeatReservation
                {
                    Reservation = reservation,
                    SeatId = selectedSeatId
                };

                reservation.SeatReservations.Add(seatReservation);
            }

            reservation.Invoice = invoice;

            await _reservationRepo.InsertAsync(reservation);
            await _unit.SaveAsync();

            ReservationDto reservationDto = _mapper.Map<ReservationDto>(reservation);
            reservationDto.User = null;
            reservationDto.Invoice = null;
            reservationDto.Screening = null;

            await SendReservationAsync(screening, currentUser, reservation);

            return reservationDto;
        }

        private static string GenerateReservationCode()
        {
            return Convert.ToString(System.Guid.NewGuid()).Substring(0, 7).ToUpper();
        }

        private async Task SendReservationAsync(Screening screening, ApplicationUserDto currentUser, Reservation reservation)
        {
            var messageContent = "";
            messageContent += "<h3>Your reservation code: " + reservation.ReservationCode + "</h3>";
            messageContent += "<p>You can pick up your movie tickets with your booking number directly from the box office during business hours.</p>";
            messageContent += "<p>Please note that your tickets must be raised no later than 30 minutes before the screening begins, otherwise the computer will cancel them. Please bring your booking confirmation with you.</p>";
            messageContent += "<p>During the evenings and weekends, count on the longer wait.</p>";
            messageContent += "<p>Cancellation: Under \"My Reservations\" in our mobile app, you can print, or cancel your reservation.</p>";
            messageContent += "<h4>Have a great time at our cinema!</h4>";


            await _emailSender.SendEmailAsync(new string[] { currentUser.Email }, "Your Ticket for the movie " + screening.Movie.Title, messageContent);
        }

        private async Task ValidateRequestAsync(ReservationUpsertRequest req, Screening screening, IEnumerable<int> selectedSeatIds)
        {
            if (screening == null)
            {
                throw new ArgumentNullException($"{nameof(Screening)} with Id {req.ScreeningId} not found.");
            }

            if (screening.DateAndTime < DateTime.UtcNow)
            {
                throw new ScreeningAvailabilityException(ValidationMessages.DATE_NOT_FUTURE);
            }

            if (req.SelectedSeats == null || req.SelectedSeats.Count == 0)
            {
                throw new ScreeningAvailabilityException(ValidationMessages.NO_SEATS_SELECTED);
            }

            bool areAllSeatsFree = await _screeningService.AreSeatsFreeAsync(req.ScreeningId, selectedSeatIds);

            if (!areAllSeatsFree)
            {
                throw new ScreeningAvailabilityException(ValidationMessages.ALL_SEATS_NOT_FREE);
            }
        }

        public Task<ReservationDto> UpdateAsync(int id, ReservationUpsertRequest req)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> ChangeReservationStatus(int id)
        {
            Reservation reservation = await _reservationRepo.GetAsync(id);
            if (reservation == null) return false;

            reservation.IsCancelled = !reservation.IsCancelled;

            await _unit.SaveAsync();

            return true;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Invoice CreateInvoice(Reservation reservation, int pricingId, int ticketQuantity)
        {
            decimal taxPercentage = _configuration.GetValue<decimal>("Cinema:VatTaxPercentageDecimal");

            Invoice invoice = new Invoice
            {
                Reservation = reservation,
                PricingId = pricingId
            };

            invoice.Price = invoice.Reservation.Screening.Pricing.Price * ticketQuantity;
            invoice.TaxAmount = invoice.Price * taxPercentage;

            return invoice;
        }

        private async Task<bool> ValidateStatusChange(int screeningId)
        {
            Screening screening = await _screeningRepo.GetAsync(screeningId);

            if (screening == null || screening.DateAndTime <= DateTime.UtcNow) return false;

            if (screening.DateAndTime <= DateTime.UtcNow)
            {
                return false;
            }

            return true;
        }

        private ReservationStatus GetReservationStatus(ReservationDto reservation)
        {
            if (reservation.IsCancelled)
            {
                return ReservationStatus.CANCELED;
            }
            else if (reservation.Invoice == null)
            {
                return ReservationStatus.BOOKED;
            }
            else
            {
                return ReservationStatus.PAID;
            }
        }
    }
}
