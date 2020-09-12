using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reports;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class ReportService : IReportService
    {
        private readonly IReservationRepository _reservationRepo;

        public ReportService(IUnitOfWork unit)
        {
            _reservationRepo = unit.Reservations;
        }

        public async Task<YearlySalesReportDto> GetYearlySalesReportPerUserAsync(UserYearlySalesSearchRequest searchRequest)
        {
            List<UserMonthlySalesDto> userSales = await GetUserSalesAsync(searchRequest.Year);

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

        private async Task<List<UserMonthlySalesDto>> GetUserSalesAsync(int year)
        {
            List<string> includes = new List<string> { nameof(Reservation.User), nameof(Reservation.Invoice) };
            IEnumerable<Reservation> reservations = await _reservationRepo.GetAsync(x => x.CreatedAt.Year == year, includes);

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
