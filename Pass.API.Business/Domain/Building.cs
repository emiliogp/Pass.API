using Pass.API.Interfaces.Entities;

namespace Pass.API.Business.Domain
{
    public class Building : IBuilding
	{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
