using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Movies;
using Cinema.Services.Factory;
using Cinema.Services.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    public class ReservationTicketsController : BaseController
    {

        public ReservationTicketsController(ApplicationDbContext context) : base(context) { }
        public IActionResult Index()
        {
            return View();
        }
    }
}