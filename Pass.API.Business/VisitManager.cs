using System;
using System.Collections.Generic;
using System.Text;
using Pass.API.Interfaces;
using Pass.API.Interfaces.Repositories;

namespace Pass.API.Business
{
    public class VisitManager
    {
        private IEntityRepository _buidingRepository;

        public VisitManager(IEntityRepository buildingRepository)
        {
            _buidingRepository = buildingRepository;
        }


    }
}
