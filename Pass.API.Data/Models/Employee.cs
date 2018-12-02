using System;
using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class Employee
    {
        public Employee()
        {
            VisitCreatedByNavigation = new HashSet<Visit>();
            VisitVisitedPersonNavigation = new HashSet<Visit>();
        }

        public int EmployeeKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NetworkId { get; set; }
        public string Job { get; set; }

        public ICollection<Visit> VisitCreatedByNavigation { get; set; }
        public ICollection<Visit> VisitVisitedPersonNavigation { get; set; }
    }
}
