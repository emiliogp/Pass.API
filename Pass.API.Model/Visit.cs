﻿using System;
using System.Collections.Generic;
using System.Text;
using Pass.API.Interfaces.Entities;

namespace Pass.API.Model
{
    public class VisitDTO : IVisit
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
    }
}
