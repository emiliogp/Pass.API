using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pass.API.Model;
using Pass.API.Interfaces;

namespace Pass.API.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Buildings
        [HttpGet]
        public IEnumerable<EmployeeDTO> Get()
        {
            return _repository.GetAll().Cast<EmployeeDTO>();
        }
    }
}