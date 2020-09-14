namespace Cinema.Models.Dtos.Reports
{
    public class DashboardWidgetsDto
    {
        public int TicketsSold { get; set; }
        public int CustomersCount { get; set; }
        public int TicketsCanceled { get; set; }
        public int TotalSeatCapacities { get; set; }
        public int TotalSeatsFree { get; set; }
        public int TotalSeatsOccupied { get; set; }
    }
}
