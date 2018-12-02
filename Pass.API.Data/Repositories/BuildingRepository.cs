using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Pass.API.Service;
using Pass.API.Data.Models;
using Pass.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pass.API.Data.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private PassContext _context;

        public BuildingRepository(PassContext context)
        {
            _context = context;
        }

        public string test()
        {
            return _context.Building.Count().ToString();
        }

        public IEnumerable<BuildingDTO> GetAll()
        {
            List<BuildingDTO> buildings = new List<BuildingDTO>();
            foreach (Building b in _context.Building)
            {
                BuildingDTO building = new BuildingDTO();
                building.Id = b.BuildinKey;
                building.Name = b.Name;
                buildings.Add(building);
            }

            return buildings;
        }
    }
}
