using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;
using Cinema.Models.Requests.Users;
using Cinema.Utilities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Api.Controllers
{
    public class UsersController : BaseCRUDController<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        public UsersController(ICRUDService<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest> service) : base(service)
        {
        }
    }
}
