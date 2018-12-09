using Pass.API.Interfaces.Entities;
using System;
using System.Collections.Generic;

namespace Pass.API.Business.Domain
{
    public class Visit : IVisit
    {
        public int Id { get; set; }
        public IVisitStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IBuilding Building { get; set; }
        public IEmployee VisitedPerson { get; set; }
        public string Comments { get; set; }
        public IEmployee CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Boolean Deleted { get; set; }
        public IEnumerable<IVisitor> Visitors { get; set; }
    }
}
