using Cinema.Models.Dtos.Reports;
using Cinema.Models.Requests.Reports;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Pagination;
using System.Threading.Tasks;

namespace Cinema.Common.Interfaces.Services
{
    public interface IReportService
    {
        Task<DashboardWidgetsDto> GetDashboardWidgetsDataAsync();
        Task<YearlySalesReportDto> GetYearlySalesReportPerUserAsync(UserYearlySalesSearchRequest searchRequest);
        Task<PagedList<ScreeningCapacityDto>> GetScreeningCapacitiesAsync(ScreeningSearchRequest searchRequest);
    }
}
