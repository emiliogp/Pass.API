using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class BuildingEntity
    {
        public BuildingEntity()
        {
            Visit = new HashSet<VisitEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<VisitEntity> Visit { get; set; }
    }
}
