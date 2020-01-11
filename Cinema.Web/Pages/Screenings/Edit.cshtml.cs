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
    public class EditModel : PageModel
    {
        private readonly Cinema.DAL.Data.ApplicationDbContext _context;

        public EditModel(Cinema.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Screening Screening { get; set; }

        public SelectList MovieNameSL { get; set; }
        public SelectList HallNameSL { get; set; }

        public void PopulateMoviesDropDownList(Cinema.DAL.Data.ApplicationDbContext _context,
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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Screening = await _context.Screenings.FirstOrDefaultAsync(m => m.Id == id);

            if (Screening == null)
            {
                return NotFound();
            }


            PopulateMoviesDropDownList(_context, Screening.Movie.Id);
            PopulateHallsDropDownList(_context, Screening.Hall.Id);

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

            _context.Attach(Screening).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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
            return _context.Screenings.Any(e => e.Id == id);
        }
    }
}
