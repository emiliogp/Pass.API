using System;
using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class VisitVisitor
    {
        public int Visit { get; set; }
        public int Visitor { get; set; }

        public Visit VisitNavigation { get; set; }
        public Visitor VisitorNavigation { get; set; }
    }
}
