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
    public class IndexModel : CinemaPageModel
    {
        public IndexModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }

        public IList<Screening> Screening { get;set; }

        public async Task OnGetAsync()
        {
            Screening = await unit.Screenings.GetAsync();
        }
    }
}
