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
    public class IndexModel : CinemaPageModel
    {
        public IndexModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }
                
        public IList<Hall> Hall { get;set; }

        public async Task OnGetAsync()
        {
            Hall = await unit.Halls.GetAsync();
        }
    }
}
