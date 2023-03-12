using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_WebApi_Core.Models
{
    public class ProductDTO
    {
        public int Id
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public double Discount
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
    }
}
