using Cinema.Models.Requests;
using Cinema.Shared.Pagination;
using Cinema.Common.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
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
        public async Task<ActionResult<T>> GetById(int id, [FromQuery] ICollection<string> includes = null)
        {
            var result = await _service.GetByIdAsync(id, includes);

            return Ok(result);
        }
    }
}
