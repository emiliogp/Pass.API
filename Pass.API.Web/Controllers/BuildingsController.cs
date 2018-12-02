using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pass.API.Service;
using Pass.API.Model;
using Pass.API.Business;

namespace Pass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly IBuildingRepository _repository;
        private readonly VisitManager _visitManager;

        public BuildingsController(IBuildingRepository repository, VisitManager visitManager)
        {
            _repository = repository;
            _visitManager = visitManager;
        }

        // GET: api/Buildings
        [HttpGet]
        public IEnumerable<BuildingDTO> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Buildings/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Buildings
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Buildings/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: api/buildings/test
        [HttpGet("test", Name = "Test")]
        public string Test(int id)
        {
            return _repository.test();
        }
    }
}
