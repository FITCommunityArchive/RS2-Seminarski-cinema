using Cinema.Models.Requests;
using Cinema.Utilities;
using Cinema.Utilities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase where TSearch : BaseSearchRequest
    {
        private readonly IService<T, TSearch> _service;
        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<PagedList<T>> Get([FromQuery] TSearch search)
        {
            var result = _service.GetPaged(search);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Task<T>> GetById(int id)
        {
            var result = _service.GetById(id);

            return Ok(result);
        }
    }
}
