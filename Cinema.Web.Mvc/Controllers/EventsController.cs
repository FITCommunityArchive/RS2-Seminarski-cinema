using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cinema.Authorization.Constants;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Events;
using Cinema.Services.Enums;
using Cinema.Services.Factory;
using Cinema.Services.Factory.ViewModels;
using Cinema.Services.Helpers;
using Cinema.Web.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    [Authorize(Roles = Roles.ContentEditor + "," + Roles.Administrator)]
    public class EventsController : BaseController
    {
        public EventsController(ApplicationDbContext context) : base(context) { }

        [AllowAnonymous]
        public async Task<IActionResult> Index(SortOrder? sortOrder, string sortProperty, string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            IQueryable<Event> eventsQuery = _unit.Events.Get();

            if (!String.IsNullOrEmpty(searchString))
            {
                eventsQuery = eventsQuery.Where(x => x.Title.Contains(searchString));
            }

            if (sortOrder != null)
            {
                sortOrder = sortOrder == SortOrder.ASC ? SortOrder.DESC : SortOrder.ASC;
                eventsQuery = _unit.Events.Sort(eventsQuery, sortOrder, sortProperty);
            }
            else
            {
                sortOrder = SortOrder.ASC;
                eventsQuery = eventsQuery.OrderBy(s => s.Title);
            }

            List<EventIndexVM> events = await eventsQuery.Select(x => x.ToIndexVM()).ToListAsync();

            PaginatedList<EventIndexVM> paginatedModel
                = PaginatedList<EventIndexVM>.Create(events.AsQueryable(), pageNumber ?? 1, 10,
                sortOrder, sortProperty, searchString);

            return View(paginatedModel);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            Event cinemaEvent = await _unit.Events.GetAsync(id);

            return View(cinemaEvent.ToDetailsVM());
        }

        [HttpGet]
        public IActionResult Create()
        {
            EventCreateVM model = new EventCreateVM
            {
                EventTypes = new SelectList(_unit.EventTypes.Get().Select(x => x.CreateMaster()), "Id", "Name"),
                AuthorId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EventCreateVM model)
        {
            Event eventEntity = model.Create();

            if (model.ImageFile != null)
            {
                var fileName = FileHelper.GetUniqueName(model.ImageFile.FileName);
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).FullName;
                string fullPath = projectDirectory + "uploads/events";
                var filePath = Path.Combine(fullPath, fileName);
                model.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
                model.Image = fileName; // Set the file name
            }

            await _unit.Events.InsertAsync(eventEntity);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            SelectList eventTypes = new SelectList(_unit.EventTypes.Get().Select(x => x.CreateMaster()), "Id", "Name");

            Event eventEntity = await _unit.Events.GetAsync(id);

            return View(eventEntity.ToCreateVM(eventTypes));
        }

        public async Task<IActionResult> Edit(EventCreateVM model)
        {
            Event eventEntity = model.Create();
            await _unit.Events.UpdateAsync(eventEntity, model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Details), new { id = eventEntity.Id });
        }
        
        public async Task<IActionResult> Delete(int id)
        {
            await _unit.Events.DeleteAsync(id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }


        [Route("LatestEvents"), AllowAnonymous]
        public IActionResult LatestEvents(int? pageNumber)
        {
            IQueryable<Event> eventsQuery = _unit.Events.Get();

            ViewData["RecentNews"] = _unit.News.Get().Take(3).ToList();
            ViewData["NewsTypes"] = _unit.NewsTypes.Get().ToList();

            PaginatedList<Event> paginatedModel = PaginatedList<Event>.Create(eventsQuery.AsQueryable(), pageNumber ?? 1, 4);
            return View("Events", paginatedModel);
        }
    }
}