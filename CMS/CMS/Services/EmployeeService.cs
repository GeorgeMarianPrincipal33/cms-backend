using CMS.Data;
using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return dbContext.Employees.ToArray();
        }

        public void AddEmployee(Employee employee)
        {
            dbContext.Add(employee);
            dbContext.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = dbContext.Employees.Find(id);
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
        }

        public IEnumerable<Employee> SearchByName(string name)
        {
            return dbContext.Employees.Where(employess => employess.Name.ToLower().Contains(name) || employess.Surname.ToLower().Contains(name));
        }

        public IEnumerable<Employee> SortByName()
        {
            return dbContext.Employees.OrderBy(employee => employee.Name).ToArray();
        }
    }
}
