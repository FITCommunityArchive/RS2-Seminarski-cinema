using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reports;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class ReportService : IReportService
    {
        private readonly IReservationRepository _reservationRepo;
        private readonly IScreeningService _screeningService;
        private readonly IRepository<SeatReservation, int> _seatReservationRepo;

        public ReportService(IUnitOfWork unit, IScreeningService screeningService)
        {
            _reservationRepo = unit.Reservations;
            _seatReservationRepo = unit.Repository<SeatReservation, int>();
            _screeningService = screeningService;
        }

        public async Task<YearlySalesReportDto> GetYearlySalesReportPerUserAsync(UserYearlySalesSearchRequest searchRequest)
        {
            List<UserMonthlySalesDto> userSales = await GetUserSalesAsync(searchRequest);
            userSales = ApplySorting(userSales, searchRequest);

            PagedList<UserMonthlySalesDto> pagedModel = PagedList<UserMonthlySalesDto>.Create(userSales, searchRequest.PageIndex, searchRequest.PageSize);

            YearlySalesReportDto monthlySales = new YearlySalesReportDto
            {
                UserMonthlySales = pagedModel,
                MonthlyTotalsForPage = pagedModel.Data.SelectMany(x => x.UserMonthlyTotals)
                                                      .GroupBy(x => x.MonthNumber)
                                                      .Select(x => new MonthlySaleTotalDto
                                                      {
                                                          MonthNumber = x.Key,
                                                          Total = x.Sum(y => y.Total)
                                                      }).ToList()
            };

            monthlySales.YearlyTotalForPage = monthlySales.MonthlyTotalsForPage.Sum(x => x.Total);

            return monthlySales;
        }

        public async Task<PagedList<ScreeningCapacityDto>> GetScreeningCapacitiesAsync(ScreeningSearchRequest searchRequest)
        {
            List<string> screeningIncludes = new List<string> { nameof(Screening.Hall), nameof(Screening.Movie) };
            searchRequest.Includes = screeningIncludes;

            IPagedList<ScreeningDto> pagedScreenings = await _screeningService.GetPagedAsync(searchRequest);
            IEnumerable<int> screeningIds = pagedScreenings.Data.Select(x => x.Id);

            List<string> seatReservationIncludes = new List<string> { nameof(SeatReservation.Reservation) };
            IEnumerable<SeatReservation> seatReservations = await _seatReservationRepo.GetAsync(x => screeningIds.Contains(x.Reservation.ScreeningId), seatReservationIncludes);

            List<ScreeningCapacityDto> screeningCapacities = pagedScreenings.Data.Select(x => new ScreeningCapacityDto
            {
                Screening = x,
                Capacity = x.Hall.NumberOfColumns * x.Hall.NumberOfRows,
                Occupied = seatReservations.Count(y => y.Reservation.ScreeningId == x.Id)
            }).ToList();

            foreach (var screening in screeningCapacities)
            {
                screening.Free = screening.Capacity - screening.Occupied;
            }

            PagedList<ScreeningCapacityDto> pagedScreeningCapacities = PagedList<ScreeningCapacityDto>.Create(screeningCapacities, searchRequest.PageIndex, searchRequest.PageSize);

            return pagedScreeningCapacities;
        }

        private List<UserMonthlySalesDto> ApplySorting(List<UserMonthlySalesDto> monthlySales, ISearchRequest searchRequest)
        {
            if (searchRequest.SortColumn != "YearlyTotal") return monthlySales;

            if (searchRequest.SortOrder == SortOrder.ASC)
            {
                monthlySales = monthlySales.OrderBy(x => x.UserYearlyTotal).ToList(); 
            }
            else
            {
                monthlySales = monthlySales.OrderByDescending(x => x.UserYearlyTotal).ToList();
            }

            return monthlySales;
        }

        private async Task<List<UserMonthlySalesDto>> GetUserSalesAsync(UserYearlySalesSearchRequest searchRequest)
        {
            IEnumerable<Reservation> reservations = await _reservationRepo.GetForYearlySalesReportAsync(searchRequest, searchRequest.Year, searchRequest.UserId, searchRequest.UserFullName);

            List<UserMonthlySalesDto> userSales = reservations.Select(x => x.User).Distinct()
                                                               .Select(x => new UserMonthlySalesDto
                                                               {
                                                                   UserId = x.Id,
                                                                   UserFullName = x.FullName,
                                                                   UserMonthlyTotals = CalculateUserMonthlySales(x.Id, reservations)
                                                               }).ToList();

            foreach (var userSale in userSales)
            {
                userSale.UserYearlyTotal = CalculateUserTotal(userSale);
            }

            return userSales;
        }

        private decimal CalculateUserTotal(UserMonthlySalesDto userSale)
        {
            return userSale.UserMonthlyTotals.Sum(x => x.Total);
        }

        private List<MonthlySaleTotalDto> CalculateUserMonthlySales(int id, IEnumerable<Reservation> usersWithReservations)
        {
            List<MonthlySaleTotalDto> monthlySales = new List<MonthlySaleTotalDto>();

            for (int i = 0; i < 12; i++)
            {
                decimal monthlyTotal = usersWithReservations.Where(x => x.Invoice != null
                                                                 && x.UserId == id
                                                                 && x.CreatedAt.Month == i + 1)
                                                            .Sum(x => x.Invoice.Price + x.Invoice.TaxAmount);
                MonthlySaleTotalDto monthlySale = new MonthlySaleTotalDto
                {
                    MonthNumber = i + 1,
                    Total = monthlyTotal
                };

                monthlySales.Add(monthlySale);
            }

            return monthlySales;
        }
    }
}
