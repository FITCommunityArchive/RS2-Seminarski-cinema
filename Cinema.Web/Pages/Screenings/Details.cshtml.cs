using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Domain.Entities;
using Cinema.DAL.Data;

namespace Cinema.Web.Pages.Screenings
{
    public class DetailsModel : PageModel
    {
        private readonly Cinema.DAL.Data.ApplicationDbContext _context;

        public DetailsModel(Cinema.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Screening Screening { get; set; }

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
            return Page();
        }
    }
}
