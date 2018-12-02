using System;
using System.Collections.Generic;
using System.Text;
using Pass.API.Service;

namespace Pass.API.Business
{
    public class VisitManager
    {
        private IBuildingRepository _buidingRepository;

        public VisitManager(IBuildingRepository buildingRepository)
        {
            _buidingRepository = buildingRepository;
        }


    }
}
