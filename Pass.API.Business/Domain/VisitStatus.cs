using Pass.API.Interfaces.Entities;

namespace Pass.API.Business.Domain
{
    public class VisitStatus : IVisitStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
