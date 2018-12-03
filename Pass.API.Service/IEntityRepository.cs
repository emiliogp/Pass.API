using System;
using System.Collections.Generic;
using System.Text;

namespace Pass.API.Interfaces
{
    /// <summary>
    /// Contains methods common to all entities
    /// </summary>
    public interface IEntityRepository
    {
        string test();

        IEnumerable<IEntityDTO> GetAll();

    }
}
