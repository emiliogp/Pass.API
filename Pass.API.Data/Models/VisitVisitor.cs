namespace Pass.API.Data.Models
{
    public partial class VisitVisitorEntity
    {
        public int Visit { get; set; }
        public int Visitor { get; set; }

        public VisitEntity VisitNavigation { get; set; }
        public VisitorEntity VisitorNavigation { get; set; }
    }
}
