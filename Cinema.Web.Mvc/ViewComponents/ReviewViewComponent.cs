using Cinema.DTO.ViewModels.Reviews;
using Microsoft.AspNetCore.Mvc;
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
