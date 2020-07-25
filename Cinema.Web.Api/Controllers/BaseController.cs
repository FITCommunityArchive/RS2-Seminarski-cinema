using Cinema.Models.Requests;
using Cinema.Shared;
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
        public async Task<ActionResult<PagedList<T>>> Get([FromQuery] TSearch search)
        {
            var result = await _service.GetPagedAsync(search);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);

            return Ok(result);
        }
    }
}
