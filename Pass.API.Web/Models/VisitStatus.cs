using Pass.API.Interfaces.Entities;

namespace Pass.API.Web.Models
{
    public class VisitStatusDTO : IVisitStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
