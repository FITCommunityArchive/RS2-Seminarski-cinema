using Cinema.Shared.Pagination;
using System.Collections.Generic;

namespace Cinema.Models.Dtos.Reports
{
    public class YearlySalesReportDto
    {
        public decimal YearlyTotalForPage { get; set; }
        public IList<MonthlySaleTotalDto> MonthlyTotalsForPage { get; set; }
        public PagedList<UserMonthlySalesDto> UserMonthlySales { get; set; }
    }
}
