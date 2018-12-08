using Pass.API.Interfaces.Entities;

namespace Pass.API.Business.Domain
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NetworkId { get; set; }
        public string Job { get; set; }
    }
}
