using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;

namespace Cinema.Web.Pages.Movies
{
    public class EditModel : CinemaPageModel
    {
        public EditModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }
 
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            unit.Context.Attach(Movie).State = EntityState.Modified;

            try
            {
                await unit.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(Movie.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MovieExists(int id)
        {
            return unit.Context.Movies.Any(e => e.Id == id);
        }
    }
}
