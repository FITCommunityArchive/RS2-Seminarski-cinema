using Cinema.DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Cinema.Web.Mvc.Controllers
{
    public class BaseController : Controller
    {
        protected UnitOfWork _unit;
        protected readonly IConfiguration _configuration;

        public BaseController(ApplicationDbContext context, IConfiguration configuration)
        {
            _unit = new UnitOfWork(context, configuration);
            _configuration = configuration;
        }
    }
}