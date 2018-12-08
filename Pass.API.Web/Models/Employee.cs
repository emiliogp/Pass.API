using Pass.API.Interfaces.Entities;

namespace Pass.API.Web.Models
{
    public class EmployeeDTO : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NetworkId { get; set; }
        public string Job { get; set; }
    }
}
