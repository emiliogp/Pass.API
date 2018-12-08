using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class VisitStatusEntity
    {
        public VisitStatusEntity()
        {
            Visit = new HashSet<VisitEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<VisitEntity> Visit { get; set; }
    }
}
