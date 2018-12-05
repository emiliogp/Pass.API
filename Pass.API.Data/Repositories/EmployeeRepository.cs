using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Pass.API.Interfaces;
using Pass.API.Data.Models;
using Pass.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Pass.API.Interfaces.Entities;
using Pass.API.Interfaces.Repositories;

namespace Pass.API.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private PassContext _context;

        public EmployeeRepository(PassContext context)
        {
            _context = context;
        }

        public string test()
        {
            return _context.Employee.Count().ToString();
        }

        public IEnumerable<IEntity> GetAll()
        {
            List<EmployeeDTO> Employees = new List<EmployeeDTO>();
            foreach (Employee e in _context.Employee)
            {
                EmployeeDTO Employee = new EmployeeDTO();
                Employee.Id = e.EmployeeKey;
                Employee.FirstName = e.FirstName;
                Employee.LastName = e.LastName;
                Employee.Email = e.Email;
                Employee.NetworkId = e.NetworkId;
                Employee.Job = e.Job;
                Employees.Add(Employee);
            }

            return Employees;
        }

        public IEntity GetById(int Id)
        {
            Employee e = _context.Employee.Where(em => em.EmployeeKey == Id).FirstOrDefault();
            EmployeeDTO employee = null;
            if (e != null)
            {
                employee = new EmployeeDTO();
                employee.Id = e.EmployeeKey;
                employee.FirstName = e.FirstName;
                employee.LastName = e.LastName;
                employee.Email = e.Email;
                employee.NetworkId = e.NetworkId;
                employee.Job = e.Job;

            }

            return employee;
        }
    }
}
