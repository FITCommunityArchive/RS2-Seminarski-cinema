using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class UsersController : BaseCRUDController<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        public UsersController(ICRUDService<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest> service) : base(service)
        {
        }
    }
}
