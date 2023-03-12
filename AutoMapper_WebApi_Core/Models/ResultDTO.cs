using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_WebApi_Core.Models
{
    public class ResultDTO
    {
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
       
    }
}
