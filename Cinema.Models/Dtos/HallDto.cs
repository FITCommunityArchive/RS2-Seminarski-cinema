namespace Cinema.Models.Dtos
{
    public class HallDto : BaseDto
    {
        public string Name { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }
}