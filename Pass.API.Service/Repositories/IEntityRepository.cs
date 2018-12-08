using System.Collections.Generic;

namespace Pass.API.Interfaces.Repositories
{
    /// <summary>
    /// Contains methods common to all entities
    /// </summary>
    public interface IEntityRepository<T>
    {        

        IEnumerable<T> GetAll();

        T GetById(int Id);

    }
}
