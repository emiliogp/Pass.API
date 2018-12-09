using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pass.API.Business;
using Pass.API.Business.Domain;
using Pass.API.Web.Models;
using System.Collections.Generic;

namespace Pass.API.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly VisitManager _visitManager;
        private readonly IMapper _mapper;

        public EmployeesController(VisitManager visitManager, IMapper mapper)
        {
            _visitManager = visitManager;
            _mapper = mapper;
        }
        
        //api/employees
        [HttpGet]
        public IEnumerable<EmployeeDTO> Get(int? count)
        {
            return _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDTO>>(_visitManager.loadAllEmployees(count));
        }

        //api/employees/lastName&count=10
        [HttpGet("{id:int}")]
        public EmployeeDTO GetById(int id)
        {
            return _mapper.Map<EmployeeDTO>(_visitManager.loadEmployeById(id));
        }

        //api/employees/lastName&count=10
        [HttpGet("{lastName}")]
        public IEnumerable<EmployeeDTO> GetByLastName(string lastName, int? count)
        {
            return _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDTO>>(_visitManager.loadEmployeesByLastName(lastName, count));
        }
    }
}