using Cinema.Models.Requests;
using Cinema.Common.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch> where TSearch : BaseSearchRequest
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;

        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<T>> Insert(TInsert req)
        {
            var result = await _service.InsertAsync(req);

            if (req == null)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<T>> Update(int id, [FromBody] TUpdate req)
        {
            return await _service.UpdateAsync(id, req);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<T>> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (result)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
