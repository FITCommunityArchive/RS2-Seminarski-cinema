using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reports;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Common.Interfaces.Dal;
using Cinema.Common.Interfaces.Services;
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
        private readonly IMapper _mapper;
        private readonly IRepository<SeatReservation, int> _seatReservationRepo;

        public ReportService(IUnitOfWork unit, IScreeningService screeningService, IMapper mapper)
        {
            _reservationRepo = unit.Reservations;
            _seatReservationRepo = unit.Repository<SeatReservation, int>();
            _screeningService = screeningService;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets summed sales per user and month, with a total sum and monthly sums for a year. The returned amounts are without VAT.
        /// </summary>
        /// <param name="searchRequest"></param>
        /// <returns></returns>
        public async Task<YearlySalesReportDto> GetYearlySalesReportPerUserAsync(UserYearlySalesSearchRequest searchRequest)
        {
            List<UserMonthlySalesDto> userSales = await GetUserSalesAsync(searchRequest);
            userSales = ApplySortingForSalesReport(userSales, searchRequest);

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
            List<ScreeningDto> screenings = await GetScreeningsAsync(searchRequest);
            IEnumerable<int> screeningIds = screenings.Select(x => x.Id);

            List<string> seatReservationIncludes = new List<string> { nameof(SeatReservation.Reservation) };
            IEnumerable<SeatReservation> seatReservations = await _seatReservationRepo.GetAsync(x => screeningIds.Contains(x.Reservation.ScreeningId), seatReservationIncludes);
            
            List<ScreeningCapacityDto> screeningCapacities = GetScreeningCapacities(screenings, seatReservations);

            screeningCapacities = ApplySortingForScreeningCapacitiesReport(screeningCapacities, searchRequest);

            PagedList<ScreeningCapacityDto> pagedScreeningCapacities = PagedList<ScreeningCapacityDto>.Create(screeningCapacities, searchRequest.PageIndex, searchRequest.PageSize);

            return pagedScreeningCapacities;
        }

        private static List<ScreeningCapacityDto> GetScreeningCapacities(List<ScreeningDto> screenings, IEnumerable<SeatReservation> seatReservations)
        {
            List<ScreeningCapacityDto> screeningCapacities = screenings.Select(x => new ScreeningCapacityDto
            {
                Screening = x,
                Capacity = x.Hall.NumberOfColumns * x.Hall.NumberOfRows,
                Occupied = seatReservations.Count(y => y.Reservation.ScreeningId == x.Id)
            }).ToList();

            foreach (var screening in screeningCapacities)
            {
                screening.Free = screening.Capacity - screening.Occupied;
            }

            return screeningCapacities;
        }

        private async Task<List<ScreeningDto>> GetScreeningsAsync(ScreeningSearchRequest searchRequest)
        {
            List<string> screeningIncludes = new List<string> { nameof(Screening.Hall), nameof(Screening.Movie) };
            searchRequest.Includes = screeningIncludes;

            List<ScreeningDto> screenings = await _screeningService.GetAsync(searchRequest);
            return screenings;
        }

        private List<ScreeningCapacityDto> ApplySortingForScreeningCapacitiesReport(List<ScreeningCapacityDto> screeningCapacities, ISearchRequest searchRequest)
        {     
            if (searchRequest.SortOrder == SortOrder.ASC)
            {
                switch (searchRequest.SortColumn)
                {
                    case nameof(ScreeningCapacityDto.Capacity):
                        screeningCapacities = screeningCapacities.OrderBy(x => x.Capacity).ToList();
                        break;
                    case nameof(ScreeningCapacityDto.Occupied):
                        screeningCapacities = screeningCapacities.OrderBy(x => x.Occupied).ToList();
                        break;
                    case nameof(ScreeningCapacityDto.Free):
                        screeningCapacities = screeningCapacities.OrderBy(x => x.Free).ToList();
                        break;
                    default:
                        break;
                }                
            }
            else
            {
                switch (searchRequest.SortColumn)
                {
                    case nameof(ScreeningCapacityDto.Capacity):
                        screeningCapacities = screeningCapacities.OrderByDescending(x => x.Capacity).ToList();
                        break;
                    case nameof(ScreeningCapacityDto.Occupied):
                        screeningCapacities = screeningCapacities.OrderByDescending(x => x.Occupied).ToList();
                        break;
                    case nameof(ScreeningCapacityDto.Free):
                        screeningCapacities = screeningCapacities.OrderByDescending(x => x.Free).ToList();
                        break;
                    default:
                        break;
                }
            }

            return screeningCapacities;
        }

        private List<UserMonthlySalesDto> ApplySortingForSalesReport(List<UserMonthlySalesDto> monthlySales, ISearchRequest searchRequest)
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
                                                            .Sum(x => x.Invoice.Price);
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
