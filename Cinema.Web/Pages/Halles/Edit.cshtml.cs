using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.Domain.Entities;
using Cinema.DAL.Data;

namespace Cinema.Web.Pages.Halles
{
    public class EditModel : CinemaPageModel
    {
        public EditModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            unit.Context.Attach(Hall).State = EntityState.Modified;

            try
            {
                await unit.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HallExists(Hall.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HallExists(int id)
        {
            return unit.Context.Halls.Any(e => e.Id == id);
        }
    }
}
