using CMS.Models;
using CMS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return employeeService.GetEmployees();
        }

        [HttpPost]
        public void AddEmployee(string name, string surname, string email, int gender, DateTime birthdate, string profileImage)
        {
            Employee newEmployee = new Employee() {Name = name, Surname = surname, Email = email, Gender = gender, Birthdate = birthdate, ProfileImage = profileImage };

            employeeService.AddEmployee(newEmployee);
        }
        
        [HttpPost]
        public void RemoveEmployee(int id)
        {
            employeeService.DeleteEmployee(id);
        }

        [HttpGet]
        public IEnumerable<Employee> SearchEmployee(string name)
        {
            return employeeService.SearchByName(name);
        }

        [HttpGet]
        public IEnumerable<Employee> SortEmployees()
        {
            return employeeService.SortByName();
        }
    }
}
