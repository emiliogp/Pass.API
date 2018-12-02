using System;
using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class Visitor
    {
        public Visitor()
        {
            VisitVisitor = new HashSet<VisitVisitor>();
        }

        public int VisitorKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }

        public ICollection<VisitVisitor> VisitVisitor { get; set; }
    }
}
