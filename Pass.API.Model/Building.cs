using System;
using Pass.API.Interfaces;

namespace Pass.API.Model
{
	public class BuildingDTO : IEntityDTO
	{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
