using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cinema.Domain.Entities;
using Cinema.DAL.Data;

namespace Cinema.Web.Pages.Halles
{
    public class CreateModel : CinemaPageModel
    {
        public CreateModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context)
        {
  
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hall Hall { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            unit.Halls.Insert(Hall);

            await unit.SaveAsync();

            return RedirectToPage("./Index");
        }
    }
}
