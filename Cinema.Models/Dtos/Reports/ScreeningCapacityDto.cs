namespace Cinema.Models.Dtos.Reports
{
    public class ScreeningCapacityDto
    {
        public ScreeningDto Screening { get; set; }
        public int Capacity { get; set; }
        public int Occupied { get; set; }
        public int Free { get; set; }
    }
}
