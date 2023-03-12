using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_WebApi_Core.Models
{
    public class ProjectProfile:Profile
    {
        public ProjectProfile()
        {
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<ProductDTO,Product>()
                .ForMember(product => product.Name, 
                           proddto => proddto.MapFrom(proddto => proddto.ProductName));


           
        }
    

        
    }
}
