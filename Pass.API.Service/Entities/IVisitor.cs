namespace Pass.API.Interfaces.Entities
{
    public interface IVisitor : IEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Company { get; set; }
        string Comments { get; set; }
    }
}
