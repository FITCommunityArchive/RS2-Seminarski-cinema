using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cinema.Authorization.Constants;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Events;
using Cinema.DTO.ViewModels.News;
using Cinema.Services.Enums;
using Cinema.Services.Factory;
using Cinema.Services.Factory.ViewModels;
using Cinema.Web.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    [Authorize(Roles = Roles.ContentEditor + "," + Roles.Administrator)]
    public class NewsController : BaseController
    {
        public NewsController(ApplicationDbContext context) : base(context) { }

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

            IQueryable<News> newsQuery = _unit.News.Get();

            if (!String.IsNullOrEmpty(searchString))
            {
                newsQuery = newsQuery.Where(x => x.Title.Contains(searchString));
            }

            if (sortOrder != null)
            {
                sortOrder = sortOrder == SortOrder.ASC ? SortOrder.DESC : SortOrder.ASC;
                newsQuery = _unit.News.Sort(newsQuery, sortOrder, sortProperty);
            }
            else
            {
                sortOrder = SortOrder.ASC;
                newsQuery = newsQuery.OrderBy(s => s.Title);
            }

            List<NewsIndexVM> news = await newsQuery.Select(x => x.ToIndexVM()).ToListAsync();

            PaginatedList<NewsIndexVM> paginatedModel
                = PaginatedList<NewsIndexVM>.Create(news.AsQueryable(), pageNumber ?? 1, 10,
                sortOrder, sortProperty, searchString);

            return View(paginatedModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            NewsCreateVM model = new NewsCreateVM
            {
                NewsTypes = new SelectList(_unit.NewsTypes.Get().Select(x => x.CreateMaster()), "Id", "Name"),
                AuthorId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            News news = await _unit.News.GetAsync(id);

            return View(news.ToDetailsVM());
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewsCreateVM model)
        {
            News news = model.Create();

            await _unit.News.InsertAsync(news);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            SelectList newsTypes = new SelectList(_unit.NewsTypes.Get().Select(x => x.CreateMaster()), "Id", "Name");

            News news = await _unit.News.GetAsync(id);

            return View(news.ToCreateVM(newsTypes));
        }

        public async Task<IActionResult> Edit(NewsCreateVM model)
        {
            News news = model.Create();
            await _unit.News.UpdateAsync(news, model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Details), new { id = news.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _unit.News.DeleteAsync(id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}