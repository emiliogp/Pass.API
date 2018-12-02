using System;
using System.Collections.Generic;
using System.Text;
using Pass.API.Model;

namespace Pass.API.Service
{
    public interface IBuildingRepository
    {
        string test();

        IEnumerable<BuildingDTO> GetAll();

    }
}
