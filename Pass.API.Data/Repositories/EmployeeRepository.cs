using AutoMapper;
using Pass.API.Business.Domain;
using Pass.API.Data.Models;
using Pass.API.Interfaces.Entities;
using Pass.API.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Pass.API.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private PassContext _context;
        private readonly IMapper _mapper;

        public EmployeeRepository(PassContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<IEmployee> GetAll(int? count)
        {
            var foundEmployees = _context.Employee.Where(_ => true);
            if (count.HasValue)
            {
                foundEmployees = foundEmployees.Take(count.Value);
            }
            foundEmployees = foundEmployees.OrderBy(e => e.LastName).ThenBy(e => e.FirstName);

            return foundEmployees.Select(e => _mapper.Map<Employee>(e));
        }

        public IEnumerable<IEmployee> GetByLastName(string filter, int? count)
        {            
            var foundEmployees = _context.Employee.Where(e => e.LastName.StartsWith(filter));
            if(count.HasValue) {
                foundEmployees = foundEmployees.Take(count.Value);
            }
            foundEmployees = foundEmployees.OrderBy(e => e.LastName).ThenBy(e => e.FirstName);

            return foundEmployees.Select(e => _mapper.Map<Employee>(e));
        }

        public IEmployee GetById(int Id)
        {
            EmployeeEntity e = _context.Employee.Where(em => em.Id == Id).FirstOrDefault();
            return _mapper.Map<Employee>(e);
        }
    }
}
