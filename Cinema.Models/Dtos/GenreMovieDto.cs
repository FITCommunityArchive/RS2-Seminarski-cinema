namespace Cinema.Models.Dtos
{
    public class GenreMovieDto : BaseDto
    {
        public int GenreId { get; set; }
        public GenreDto Genre { get; set; }
    }
}
