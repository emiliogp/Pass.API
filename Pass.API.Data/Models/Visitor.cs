using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class VisitorEntity
    {
        public VisitorEntity()
        {
            VisitVisitor = new HashSet<VisitVisitorEntity>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }

        public ICollection<VisitVisitorEntity> VisitVisitor { get; set; }
    }
}
