using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Web.Data;
using Cinema.Domain.Entities;

namespace Cinema.Web.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Cinema.Web.Data.ApplicationDbContext _context;

        public IndexModel(Cinema.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
