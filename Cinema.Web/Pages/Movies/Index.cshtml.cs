using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;

namespace Cinema.Web.Pages.Movies
{
    public class IndexModel : CinemaPageModel
    {
        public IndexModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context) { }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await unit.Movies.GetAsync();
        }
    }
}
