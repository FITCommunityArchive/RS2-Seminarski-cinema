using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Cinema.Domain.Entities;
using Cinema.Web.Data;

namespace Cinema.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public IList<Screening> Screenings { get; set; }

        public async Task OnGetAsync()
        {
            Screenings = await _context.Screenings
                .ToListAsync();
        }
    }
}
