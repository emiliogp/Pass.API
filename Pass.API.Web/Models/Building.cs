using Pass.API.Interfaces.Entities;

namespace Pass.API.Web.Models
{
    public class BuildingDTO : IBuilding
	{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
