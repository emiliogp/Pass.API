using System;
using System.Collections.Generic;

namespace Pass.API.Data.Models
{
    public partial class VisitHistory
    {
        public int VisitHistoryKey { get; set; }
        public int Visit { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public Visit VisitNavigation { get; set; }
    }
}
