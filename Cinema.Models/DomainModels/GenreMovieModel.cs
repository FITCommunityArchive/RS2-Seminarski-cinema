using Cinema.Models.Dtos;

namespace Cinema.Models.DomainModels
{
    public class GenreMovieModel
    {
        public int Id { get; set; }
        public MasterDto Movie { get; set; }
        public MasterDto Genre { get; set; }
    }
}
