using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Api.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T,TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<T> Insert(TInsert req)
        {
            return _service.Insert(req);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<T>> Update(int id, [FromBody] TUpdate req)
        {
            return await _service.Update(id, req);
        }
    }
}
