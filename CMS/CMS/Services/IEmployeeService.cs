using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Services
{
    interface IEmployeeService
    {
        void AddEmployee(Employee employee);

        void DeleteEmployee(int id);

        void SearchByName(string name);

        void SortByName(string name);
    }
}
