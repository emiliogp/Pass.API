using System;
using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class VisitEntity
    {
        public VisitEntity()
        {
            VisitHistory = new HashSet<VisitHistoryEntity>();
            VisitVisitor = new HashSet<VisitVisitorEntity>();
        }

        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Building { get; set; }
        public int VisitedPerson { get; set; }
        public string Comments { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }

        public BuildingEntity BuildingNavigation { get; set; }
        public EmployeeEntity CreatedByNavigation { get; set; }
        public VisitStatusEntity StatusNavigation { get; set; }
        public EmployeeEntity VisitedPersonNavigation { get; set; }
        public ICollection<VisitHistoryEntity> VisitHistory { get; set; }
        public ICollection<VisitVisitorEntity> VisitVisitor { get; set; }
    }
}
