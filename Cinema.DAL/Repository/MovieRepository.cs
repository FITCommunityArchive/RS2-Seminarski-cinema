using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Dal.Repository
{
    public class MovieRepository : Repository<Movie, int>
    {

        public MovieRepository(ICinemaDbContext context) : base(context) { }
    }
}
