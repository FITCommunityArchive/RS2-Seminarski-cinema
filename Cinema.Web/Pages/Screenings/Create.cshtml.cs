using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Pages.Screenings
{
    public class CreateModel : PageModel
    {
        private readonly Cinema.DAL.Data.ApplicationDbContext _context;

        public CreateModel(Cinema.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Title");
            ViewData["HallId"] = new SelectList(_context.Halls, "Id", "Name");
            return Page();
        }


        [BindProperty]
        public Screening Screening { get; set; }
        

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Screenings.Add(Screening);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
