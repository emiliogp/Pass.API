using System;
using System.Collections.Generic;

namespace Pass.API.Interfaces.Entities
{
    public interface IVisit : IEntity
    {
        IVisitStatus Status { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        IBuilding Building { get; set; }
        IEmployee VisitedPerson { get; set; }
        string Comments { get; set; }
        IEmployee CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }
        Boolean Deleted { get; set; }
        IEnumerable<IVisitor> Visitors { get; set; }
    }
}
