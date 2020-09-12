using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models.Dtos.Reports
{
    public class MonthlySaleTotalDto
    {
        /// <summary>
        /// Month number format 1 - 12
        /// </summary>
        public int MonthNumber { get; set; }
        public decimal Total { get; set; }
    }
}
