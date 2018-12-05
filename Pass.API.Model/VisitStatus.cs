using System;
using System.Collections.Generic;
using System.Text;
using Pass.API.Interfaces.Entities;

namespace Pass.API.Model
{
    public class VisitStatusDTO : IVisitStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
