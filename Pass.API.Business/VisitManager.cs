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


        public IEnumerable<Employee> LoadAllEmployees(int? count)
        {
            return _employeeRepository.GetAll(count).Cast<Employee>();
        }

        public Employee LoadEmployeeById(int id)
        {
            return (Employee) _employeeRepository.GetById(id);
        }

        public IEnumerable<Employee> LoadEmployeesByLastName(string lastName, int? count)
        {
            return _employeeRepository.GetByLastName(lastName, count).Cast<Employee>();
        }

        public IEnumerable<Visit> LoadAllVisits(int? count)
        {
            return _visitRepository.GetAll(count).Cast<Visit>();
        }

        public Visit LoadVisitById(int id)
        {
            Visit visit = (Visit)_visitRepository.GetById(id);
            return visit;
        }

    }
}
