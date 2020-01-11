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
    public class IndexModel : PageModel
    {
        private readonly Cinema.DAL.Data.ApplicationDbContext _context;

        public IndexModel(Cinema.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Hall> Hall { get;set; }

        public async Task OnGetAsync()
        {
            Hall = await _context.Halls.ToListAsync();
        }
    }
}
