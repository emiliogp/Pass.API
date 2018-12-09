using Pass.API.Interfaces.Entities;

namespace Pass.API.Business.Domain
{
    public class Visitor : IVisitor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
    }
}
