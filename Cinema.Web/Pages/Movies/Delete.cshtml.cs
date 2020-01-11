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
    public class DeleteModel : CinemaPageModel
    {
        public DeleteModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }
 
        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Movie = await unit.Movies.GetAsync(id);

            if (Movie != null)
            {
                unit.Movies.Delete(Movie);
                await unit.SaveAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
