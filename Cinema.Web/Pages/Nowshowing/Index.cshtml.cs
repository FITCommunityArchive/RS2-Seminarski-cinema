using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Web.Pages.Nowshowing
{
    public class IndexModel : CinemaPageModel
    {
        public IndexModel(ApplicationDbContext context) : base(context) { }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 10;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public List<Screening> NowShowingMovies { get; set; }

        [BindProperty]
        public string ScreeningDate { get; set; }

        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
        public bool ShowFirst => CurrentPage != 1;
        public bool ShowLast => CurrentPage != TotalPages;
        public List<Screening> GetPaginatedResult(int currentPage, int pageSize = 10, string screeningdate = null)
        {
            if(screeningdate != null)
            {
                DateTime DateFilter = Convert.ToDateTime(screeningdate);
                var dataWithDate = unit.Screenings.Get(s => s.DateAndTime.Date == DateFilter.Date);
                return dataWithDate.OrderBy(d => d.Id).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            }

            var data = unit.Screenings.Get();
            return data.OrderBy(d => d.Id).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

        }

        public int GetCount()
        {
            
            if (ScreeningDate != null)
            {
                DateTime DateFilter = Convert.ToDateTime(ScreeningDate);
                var dataWithDate = unit.Screenings.Get(s => s.DateAndTime.Date == DateFilter.Date);
                return dataWithDate.Count;
            }
            
            var data = unit.Screenings.Get();
            return data.Count();
        }


        public void OnGet()
        {
            NowShowingMovies = GetPaginatedResult(CurrentPage, PageSize);
            Count = GetCount();   
        }

        public void OnPost()
        {
            
            NowShowingMovies = GetPaginatedResult(CurrentPage, PageSize, ScreeningDate);
            Count = GetCount();
        }
    }
}