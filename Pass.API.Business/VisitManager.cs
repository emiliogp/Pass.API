using Pass.API.Business.Domain;
using Pass.API.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Pass.API.Business
{
    public class VisitManager
    {
        private readonly IBuildingRepository _buidingRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IVisitRepository _visitRepository;

        public VisitManager(IBuildingRepository buildingRepository, IEmployeeRepository employeeRepository, IVisitRepository visitRepository)
        {
            _buidingRepository = buildingRepository;
            _employeeRepository = employeeRepository;
            _visitRepository = visitRepository;
        }


        public IEnumerable<Employee> loadAllEmployees()
        {
            return _employeeRepository.GetAll().Cast<Employee>();
        }



    }
}
