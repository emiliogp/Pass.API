using System;
using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class VisitStatus
    {
        public VisitStatus()
        {
            Visit = new HashSet<Visit>();
        }

        public int StatusKey { get; set; }
        public string Name { get; set; }

        public ICollection<Visit> Visit { get; set; }
    }
}
