using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cinema.Domain.Entities;
using Cinema.Web.Data;

namespace Cinema.Web.Pages.Halles
{
    public class CreateModel : PageModel
    {
        private readonly Cinema.Web.Data.ApplicationDbContext _context;

        public CreateModel(Cinema.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hall Hall { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Halls.Add(Hall);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
