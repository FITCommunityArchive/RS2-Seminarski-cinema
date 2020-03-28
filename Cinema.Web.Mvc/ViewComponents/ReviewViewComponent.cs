using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Reviews;
using Cinema.Services.Factory;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.ViewComponents
{
    public class ReviewViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ReviewIndexVM review)
        {
            return View(review);
        }
    }
}
