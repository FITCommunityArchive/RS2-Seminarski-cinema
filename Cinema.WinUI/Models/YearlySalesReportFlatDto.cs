using Cinema.Models.Dtos.Reports;
using System.Collections.Generic;

namespace Cinema.WinUI.Models
{
    public class YearlySalesReportFlatDto
    {
        public string UserId { get; set; }
        public string UserFullName { get; set; }
        public decimal YearlyTotal { get; set; }
        public List<MonthlySaleTotalDto> MonthlyTotals { get; set; }
    }
}
