namespace Cinema.Dto.DomainModels
{
    public class GenreMovieModel
    {
        public int Id { get; set; }
        public MasterModel Movie { get; set; }
        public MasterModel Genre { get; set; }
    }
}
