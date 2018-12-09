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
    public class VisitsController : ControllerBase
    {
        private readonly VisitManager _visitManager;
        private readonly IMapper _mapper;

        public VisitsController(VisitManager visitManager, IMapper mapper)
        {
            _visitManager = visitManager;
            _mapper = mapper;
        }
        
        //api/visits
        [HttpGet]
        public IEnumerable<VisitDTO> Get(int? count)
        {
            return _mapper.Map<IEnumerable<Visit>, IEnumerable<VisitDTO>>(_visitManager.loadAllVisits(count));
        }

        //api/visits/1
        [HttpGet("{id:int}")]
        public VisitDTO GetById(int id)
        {
            Visit visit = _visitManager.loadVisitById(id);
            return _mapper.Map<VisitDTO>(visit);
        }
    }
}