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
    public class DetailsModel : CinemaPageModel
    {
        public DetailsModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }

        public Screening Screening { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Screening = await unit.Screenings.GetAsync(id);

            if (Screening == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
