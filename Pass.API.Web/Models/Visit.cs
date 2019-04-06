using System;
using System.Collections.Generic;

namespace Pass.API.Web.Models
{
    public class VisitDTO
    {
        public int Id { get; set; }
        public VisitStatusDTO Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BuildingDTO Building { get; set; }
        public EmployeeDTO VisitedPerson { get; set; }
        public string Comments { get; set; }
        public EmployeeDTO CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Boolean Deleted { get; set; }
        public IEnumerable<VisitorDTO> Visitors;
    }
}
