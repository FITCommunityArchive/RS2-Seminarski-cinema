using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Domain.Entities;
using Cinema.Web.Data;

namespace Cinema.Web.Pages.Screenings
{
    public class IndexModel : PageModel
    {
        private readonly Cinema.Web.Data.ApplicationDbContext _context;

        public IndexModel(Cinema.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Screening> Screening { get;set; }

        public async Task OnGetAsync()
        {
            Screening = await _context.Screenings.ToListAsync();
        }
    }
}
