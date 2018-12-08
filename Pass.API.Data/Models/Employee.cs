using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class EmployeeEntity
    {
        public EmployeeEntity()
        {
            VisitCreatedByNavigation = new HashSet<VisitEntity>();
            VisitVisitedPersonNavigation = new HashSet<VisitEntity>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NetworkId { get; set; }
        public string Job { get; set; }

        public ICollection<VisitEntity> VisitCreatedByNavigation { get; set; }
        public ICollection<VisitEntity> VisitVisitedPersonNavigation { get; set; }
    }
}
