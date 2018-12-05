using System;
using System.Collections.Generic;
using System.Text;

namespace Pass.API.Interfaces.Entities
{
    public interface IBuilding : IEntity
    {
        string Name { get; set; }
    }
}
