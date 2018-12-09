using Pass.API.Interfaces.Entities;
using System.Collections.Generic;

namespace Pass.API.Interfaces.Repositories
{
    public interface IEmployeeRepository : IEntityRepository<IEmployee>
    {
        IEnumerable<IEmployee> GetByLastName(string filter, int? count);
    }
}
