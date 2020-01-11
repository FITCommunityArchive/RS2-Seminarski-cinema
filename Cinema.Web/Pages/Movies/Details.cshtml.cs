using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;

namespace Cinema.Web.Pages.Movies
{
    public class DetailsModel : CinemaPageModel
    {
        public DetailsModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Movie = await unit.Movies.GetAsync(id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
