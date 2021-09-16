using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();

        void AddEmployee(Employee employee);

        void DeleteEmployee(int id);

        IEnumerable<Employee> SearchByName(string name);

        IEnumerable<Employee> SortByName();
    }
}
