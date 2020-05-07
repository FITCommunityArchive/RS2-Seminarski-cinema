using Cinema.DTO.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.ViewComponents
{
    public class ValidationMessageViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ValidationMessageVM errorMessage)
        {
            return View(errorMessage);
        }
    }
}
