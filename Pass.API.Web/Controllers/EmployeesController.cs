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

        // GET: api/Buildings
        [HttpGet]
        public IEnumerable<EmployeeDTO> Get()
        {
            return _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDTO>>(_visitManager.loadAllEmployees());
        }
    }
}