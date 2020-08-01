using Microsoft.Extensions.Configuration;
using Cinema.Models.Requests;
using Cinema.Utilities.Interfaces.Services;
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
            return await _service.Insert(req);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<T>> Update(int id, [FromBody] TUpdate req)
        {
            return await _service.Update(id, req);
        }
    }
}
