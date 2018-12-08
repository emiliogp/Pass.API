namespace Pass.API.Interfaces.Entities
{
    public interface IEmployee : IEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string NetworkId { get; set; }
        string Job { get; set; }
    }
}
