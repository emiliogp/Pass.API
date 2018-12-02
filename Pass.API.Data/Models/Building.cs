using System;
using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class Building
    {
        public Building()
        {
            Visit = new HashSet<Visit>();
        }

        public int BuildinKey { get; set; }
        public string Name { get; set; }

        public ICollection<Visit> Visit { get; set; }
    }
}
