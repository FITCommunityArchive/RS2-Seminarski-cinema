using Cinema.Models.Dtos;
using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reports;
using Cinema.Models.Requests.Reservations;
using Cinema.Shared.Pagination;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IReportService
    {
        Task<YearlySalesReportDto> GetYearlySalesReportPerUserAsync(UserYearlySalesSearchRequest searchRequest);
    }
}
