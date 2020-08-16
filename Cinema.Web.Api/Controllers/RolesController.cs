using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Api.Controllers
{
    public class RolesController : BaseController<ApplicationRoleDto, BaseSearchRequest>
    {
        public RolesController(IService<ApplicationRoleDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
