using System;

namespace Pass.API.Data.Models
{
    public partial class VisitHistoryEntity
    {
        public int Id { get; set; }
        public int Visit { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public VisitEntity VisitNavigation { get; set; }
    }
}
