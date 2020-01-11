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
    public class DetailsModel : CinemaPageModel
    {
        public DetailsModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }

        public Hall Hall { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Hall = await unit.Halls.GetAsync(id);

            if (Hall == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
