using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DTO.DomainModels
{
    public class GenreMovieModel
    {
        public int Id { get; set; }
        public MasterModel Movie { get; set; }
        public MasterModel Genre { get; set; }
    }
}
