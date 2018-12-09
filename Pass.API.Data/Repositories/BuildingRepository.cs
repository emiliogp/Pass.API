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
            return _context.Building.Count().ToString();
        }

        public IEnumerable<IBuilding> GetAll(int? count)
        {
            var buildings = _context.Building.Where(_ => true);
            if (count.HasValue)
            {
                buildings = buildings.Take(count.Value);
            }
            buildings = buildings.OrderBy(v => v.Name);

            return buildings.Select(v => _mapper.Map<Building>(v));
        }

        public IBuilding GetById(int Id)
        {
            BuildingEntity b =_context.Building.Where(bu => bu.Id == Id).FirstOrDefault();
            return _mapper.Map<Building>(b);
        }
    }
}
