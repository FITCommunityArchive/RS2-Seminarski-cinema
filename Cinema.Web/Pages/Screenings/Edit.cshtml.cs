using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.Domain.Entities;
using Cinema.DAL.Data;

namespace Cinema.Web.Pages.Screenings
{
    public class EditModel : CinemaPageModel
    {
        public EditModel(ApplicationDbContext context) : base(context) { }

        [BindProperty]
        public Screening Screening { get; set; }
        public SelectList MovieNameSL { get; set; }
        public SelectList HallNameSL { get; set; }

        public void PopulateMoviesDropDownList(ApplicationDbContext _context,
            object selectedMovie = null)
        {
            var moviesQuery = from d in _context.Movies
                                   orderby d.Title // Sort by Title.
                                   select d;

            MovieNameSL = new SelectList(moviesQuery.AsNoTracking(),
                        "Id", "Title", selectedMovie);
        }

        public void PopulateHallsDropDownList(Cinema.DAL.Data.ApplicationDbContext _context,
            object selectedHall = null)
        {
            var hallsQuery = from d in _context.Halls
                                   orderby d.Name // Sort by Title.
                                   select d;

            HallNameSL = new SelectList(hallsQuery.AsNoTracking(),
                        "Id", "Name", selectedHall);
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Screening = await unit.Screenings.GetAsync(id);

            if (Screening == null)
            {
                return NotFound();
            }

            PopulateMoviesDropDownList(unit.Context, Screening.Movie.Id);
            PopulateHallsDropDownList(unit.Context, Screening.Hall.Id);

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

            unit.Context.Attach(Screening).State = EntityState.Modified;

            try
            {
                await unit.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScreeningExists(Screening.Id))
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

        private bool ScreeningExists(int id)
        {
            return unit.Context.Screenings.Any(e => e.Id == id);
        }
    }
}
