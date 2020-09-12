using Cinema.Shared.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Dtos.Reports
{
    public class YearlySalesReportDto
    {
        public decimal YearlyTotalForPage { get; set; }
        public IList<MonthlySaleTotalDto> MonthlyTotalsForPage { get; set; }
        public IPagedList<UserMonthlySalesDto> UserMonthlySales { get; set; }
    }
}
