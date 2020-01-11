using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Domain.Entities;
using Cinema.DAL.Data;

namespace Cinema.Web.Pages.Halles
{
    public class DeleteModel : PageModel
    {
        private readonly Cinema.DAL.Data.ApplicationDbContext _context;

        public DeleteModel(Cinema.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hall Hall { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hall = await _context.Halls.FirstOrDefaultAsync(m => m.Id == id);

            if (Hall == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hall = await _context.Halls.FindAsync(id);

            if (Hall != null)
            {
                _context.Halls.Remove(Hall);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
