using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Pass.API.Interfaces;
using Pass.API.Data.Models;
using Pass.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Pass.API.Interfaces.Entities;
using Pass.API.Interfaces.Repositories;

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

        public IEnumerable<IEntity> GetAll()
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

        public IEntity GetById(int Id)
        {
            Building b =_context.Building.Where(bu => bu.BuildinKey == Id).FirstOrDefault();
            BuildingDTO building = null;
            if (b != null)
            {
                building = new BuildingDTO();
                building.Id = b.BuildinKey;
                building.Name = b.Name;
            }

            return building;
        }
    }
}
