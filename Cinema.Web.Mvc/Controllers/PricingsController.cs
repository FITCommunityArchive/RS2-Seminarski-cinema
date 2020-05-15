using Cinema.Authorization.Constants;
using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Dto.ViewModels.Pricings;
using Cinema.Utilities.Constants;
using Cinema.Utilities.Enums;
using Cinema.Utilities.Factory;
using Cinema.Utilities.Factory.ViewModels;
using Cinema.Web.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class PricingsController : BaseController
    {
        public PricingsController(ApplicationDbContext context, IConfiguration configuration) : base(context, configuration) { }

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

            IQueryable<Pricing> pricingsQuery = _unit.Pricings.Get();

            if (!String.IsNullOrEmpty(searchString))
            {
                pricingsQuery = pricingsQuery.Where(x => x.Name.Contains(searchString));
            }

            pricingsQuery = _unit.Pricings.Sort(pricingsQuery, sortOrder, sortProperty);

            List<PricingIndexVM> pricings = await pricingsQuery.Select(x => x.ToIndexVM()).ToListAsync();

            PaginatedList<PricingIndexVM> paginatedModel
                = PaginatedList<PricingIndexVM>.Create(pricings.AsQueryable(), pageNumber ?? 1, 10,
                sortOrder, sortProperty, searchString);

            return View(paginatedModel);
        }

        [HttpGet]
        public IActionResult Create(string errorMessage = "")
        {
            ViewBag.ErrorMessage = errorMessage;

            PricingCreateVM model = new PricingCreateVM();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PricingCreateVM model)
        {
            Pricing pricing = model.Create();

            if (!_unit.Pricings.ValidatePrice(pricing))
            {
                return RedirectToAction(nameof(Create), new { errorMessage = ValidationMessages.PRICE_INVALID });
            }
            else if (string.IsNullOrEmpty(model.Name))
            {
                return RedirectToAction(nameof(Create), new { errorMessage = ValidationMessages.ALL_FIELDS_REQUIRED });
            }

            await _unit.Pricings.InsertAsync(pricing);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Pricing pricing = await _unit.Pricings.GetAsync(id);

            return View(pricing.ToCreateVM());
        }

        public async Task<IActionResult> Edit(PricingCreateVM model)
        {
            Pricing pricing = model.Create();

            if (!_unit.Pricings.ValidatePrice(pricing))
            {
                return RedirectToAction(nameof(Edit), new { id = pricing.Id, errorMessage = ValidationMessages.PRICE_INVALID });
            }
            else if (string.IsNullOrEmpty(model.Name))
            {
                return RedirectToAction(nameof(Edit), new { id = pricing.Id, errorMessage = ValidationMessages.ALL_FIELDS_REQUIRED });
            }

            await _unit.Pricings.UpdateAsync(pricing, model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _unit.Pricings.DeleteAsync(id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}