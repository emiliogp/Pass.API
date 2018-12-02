using System;
using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class Visit
    {
        public Visit()
        {
            VisitHistory = new HashSet<VisitHistory>();
            VisitVisitor = new HashSet<VisitVisitor>();
        }

        public int VisitId { get; set; }
        public int Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Building { get; set; }
        public int VisitedPerson { get; set; }
        public string Comments { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }

        public Building BuildingNavigation { get; set; }
        public Employee CreatedByNavigation { get; set; }
        public VisitStatus StatusNavigation { get; set; }
        public Employee VisitedPersonNavigation { get; set; }
        public ICollection<VisitHistory> VisitHistory { get; set; }
        public ICollection<VisitVisitor> VisitVisitor { get; set; }
    }
}
