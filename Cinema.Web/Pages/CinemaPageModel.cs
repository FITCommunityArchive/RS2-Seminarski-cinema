using Cinema.DAL.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Pages
{
    public class CinemaPageModel : PageModel
    {
        protected readonly UnitOfWork unit;
        public CinemaPageModel(ApplicationDbContext context)
        {
            unit = new UnitOfWork(context);
        }
    }
}
