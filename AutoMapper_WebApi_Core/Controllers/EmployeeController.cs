using AutoMapper;
using AutoMapper_WebApi_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_WebApi_Core.Controllers
{
    public class EmployeeController : Controller
    {
        public IMapper _mapper;

        //public static List<Employee> employees;

       public static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id=1,Name="John",Age=22,Salary=50000},
            new Employee(){Id=2,Name="Andrew",Age=23,Salary=60000},
            new Employee(){Id=3,Name="Peter",Age=22,Salary=50000},
            new Employee(){Id=4,Name="Mark",Age=24,Salary=70000},
            new Employee(){Id=5,Name="Amy",Age=32,Salary=165000},
            new Employee(){Id=6,Name="Sam",Age=26,Salary=40000}
        };
        public EmployeeController(IMapper mapper)
        {
            _mapper = mapper;
            //employees = GetEmployees();
        }
        public IActionResult Index()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDTO employeeDTO)
        {

            var employee = _mapper.Map<Employee>(employeeDTO);
            employees.Add(employee);
            return Ok(employee);

        }

        //public List<Employee> GetEmployees()
        //{
        //    List<Employee> employees = new List<Employee>() {
        //    new Employee(){Id=1,Name="John",Age=22,Salary=50000},
        //    new Employee(){Id=2,Name="Andrew",Age=23,Salary=60000},
        //    new Employee(){Id=3,Name="Peter",Age=22,Salary=50000},
        //    new Employee(){Id=4,Name="Mark",Age=24,Salary=70000},
        //    new Employee(){Id=5,Name="Amy",Age=32,Salary=165000},
        //    new Employee(){Id=6,Name="Sam",Age=26,Salary=40000}
        //    };

        //    return employees;
        
        //}
    }
}
