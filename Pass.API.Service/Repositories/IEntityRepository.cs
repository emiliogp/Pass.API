using System;
using System.Collections.Generic;
using System.Text;
using Pass.API.Interfaces.Entities;

namespace Pass.API.Interfaces.Repositories
{
    /// <summary>
    /// Contains methods common to all entities
    /// </summary>
    public interface IEntityRepository
    {        

        IEnumerable<IEntity> GetAll();

        IEntity GetById(int Id);

    }
}
