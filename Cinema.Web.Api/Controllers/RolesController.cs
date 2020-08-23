using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class RolesController : BaseController<ApplicationRoleDto, BaseSearchRequest>
    {
        public RolesController(IService<ApplicationRoleDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
