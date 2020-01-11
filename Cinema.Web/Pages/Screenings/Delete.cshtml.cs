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
    public class DeleteModel : CinemaPageModel
    {
        public DeleteModel(ApplicationDbContext context) : base(context) { }


        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int id)
        {

            unit.Screenings.Delete(id);
            await unit.SaveAsync();             

            return RedirectToPage("./Index");
        }
    }
}
