using AutoMapper;
using Pass.API.Business.Domain;
using Pass.API.Data.Models;
using Pass.API.Interfaces.Entities;
using Pass.API.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Pass.API.Data.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private PassContext _context;
        private readonly IMapper _mapper;



        public BuildingRepository(PassContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public string test()
        {
            return _context.Buildings.Count().ToString();
        }

        public IEnumerable<IBuilding> GetAll()
        {
            var buildings = new List<Building>();
            foreach (BuildingEntity b in _context.Buildings)
            {
                buildings.Add(_mapper.Map<Building>(b));
            }

            return buildings;
        }

        public IBuilding GetById(int Id)
        {
            BuildingEntity b =_context.Buildings.Where(bu => bu.Id == Id).FirstOrDefault();
            return _mapper.Map<Building>(b);
        }
    }
}
