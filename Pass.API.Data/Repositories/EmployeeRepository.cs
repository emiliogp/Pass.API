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

        public string test()
        {
            return _context.Employee.Count().ToString();
        }

        public IEnumerable<IEmployee> GetAll()
        {
            List<Employee> Employees = new List<Employee>();
            foreach (EmployeeEntity e in _context.Employee)
            {
                Employees.Add(_mapper.Map<Employee>(e));
            }

            return Employees;
        }

        public IEmployee GetById(int Id)
        {
            EmployeeEntity e = _context.Employee.Where(em => em.Id == Id).FirstOrDefault();
            return _mapper.Map<Employee>(e);
        }
    }
}
