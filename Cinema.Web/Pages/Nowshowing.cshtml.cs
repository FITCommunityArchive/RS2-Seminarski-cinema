using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Domain.Entities;
using Cinema.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Web.Pages
{
    public class NowshowingModel : PageModel
    {

        private readonly ApplicationDbContext _context;

        public NowshowingModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Screenings = _context.Screenings
                .ToList();
        }

        [BindProperty]
        public IList<Screening> Screenings { get; set; }

    }
}