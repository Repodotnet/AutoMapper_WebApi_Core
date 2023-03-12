using AutoMapper;
using AutoMapper_WebApi_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_WebApi_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public IMapper _mapper;

        public static List<EmployeeDTO> employees = new List<EmployeeDTO>()
        {
            new EmployeeDTO(){Id=1,Name="John",Age=22,Salary=50000},
            new EmployeeDTO(){Id=2,Name="Andrew",Age=23,Salary=60000},
            new EmployeeDTO(){Id=3,Name="Peter",Age=22,Salary=50000},
            new EmployeeDTO(){Id=4,Name="Mark",Age=24,Salary=70000},
            new EmployeeDTO(){Id=5,Name="Amy",Age=32,Salary=165000},
            new EmployeeDTO(){Id=6,Name="Sam",Age=26,Salary=40000}
        };
        public EmployeesController(IMapper mapper)
        {
            _mapper = mapper;
            
        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            EmployeeDTO emp = employees.FirstOrDefault(x => x.Id == id);
            var employee = _mapper.Map<Employee>(emp);
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDTO employeeDTO)
        {

            var employee = _mapper.Map<Employee>(employeeDTO);
            return Ok(employee);

        }
    }
}
