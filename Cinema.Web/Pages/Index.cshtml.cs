using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using Cinema.BLL;

namespace Cinema.Web.Pages
{
    public class IndexModel : CinemaPageModel
    {

        protected MovieService _movieService;
        public IndexModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context)
        {
            _movieService = new MovieService(unit);
        }


        [BindProperty]
        public List<Movie> Movies { get; set; }

        public async Task OnGet()
        {
            Movies = _movieService.GetComingSoonMovies();
        }
    }
}
