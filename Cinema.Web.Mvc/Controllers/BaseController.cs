using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.DAL.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Mvc.Controllers
{
    public class BaseController : Controller
    {
        protected UnitOfWork _unit;

        public BaseController(ApplicationDbContext context)
        {
            _unit = new UnitOfWork(context);
        }
    }
}