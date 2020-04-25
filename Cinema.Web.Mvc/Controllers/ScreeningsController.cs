using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Authorization.Constants;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Screenings;
using Cinema.Services.Factory;
using Cinema.Services.Factory.ViewModels;
using Cinema.Web.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class ScreeningsController : BaseController
    {
        public ScreeningsController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            List<ScreeningIndexVM> screenings = new List<ScreeningIndexVM>();
            if (!String.IsNullOrEmpty(searchString))
            {
                screenings = await _unit.Screenings.Get().Where(x => x.Movie.Title.Contains(searchString)).Select(x => x.ToIndexVM()).ToListAsync();
            } else
            {
                screenings = await _unit.Screenings.Get().Select(x => x.ToIndexVM()).ToListAsync();
            }
            switch (sortOrder)
            {
                case "title_desc":
                    screenings = screenings.OrderByDescending(s => s.Movie).ToList();
                    break;
                case "Date":
                    screenings = screenings.OrderBy(s => s.DateAndTime).ToList();
                    break;
                case "date" +
                "_desc":
                    screenings = screenings.OrderByDescending(s => s.DateAndTime).ToList();
                    break;
                default:
                    screenings = screenings.OrderBy(s => s.Movie).ToList();
                    break;
            }

            //List<MovieIndexVM> movies = await _unit.Movies.Get().Select(x => x.ToIndexVM()).ToListAsync();
            int pageSize = 10;
            return View(PaginatedList<ScreeningIndexVM>.Create(screenings.AsQueryable(), pageNumber ?? 1, pageSize)); 
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            Screening screening = await _unit.Screenings.GetAsync(id);

            return View(screening.ToIndexVM());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ScreeningCreateVM model = new ScreeningCreateVM
            {
                
                Movies = new SelectList(_unit.Movies.Get(), "Id", "Title"),
                Halls = new SelectList(_unit.Halls.Get(), "Id", "Name")
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ScreeningCreateVM model)
        {
            Screening screening = model.Create();

            await _unit.Screenings.InsertAsync(screening);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            SelectList movies = new SelectList(_unit.Movies.Get(), "Id", "Title");
            SelectList halls = new SelectList(_unit.Halls.Get(), "Id", "Name");

            Screening screening = await _unit.Screenings.GetAsync(id);

            return View(screening.ToCreateVM(movies, halls));
        }

        public async Task<IActionResult> Edit(ScreeningCreateVM model)
        {
            Screening screening = model.Create();

            await _unit.Screenings.UpdateAsync(screening, model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Screening screening = await _unit.Screenings.GetAsync(id);

            return View(screening.ToIndexVM());
        }

        public async Task<IActionResult> Delete(ScreeningIndexVM model)
        {
            await _unit.Screenings.DeleteAsync(model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}