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
    public class ProductController : ControllerBase
    {
        public IMapper _mapper;

        public ProductController(IMapper mapper)
        {
            _mapper = mapper;

        }
        [HttpPost]
        public IActionResult CreateEmployee(ProductDTO productDTO)
        {

            var product = _mapper.Map<Product>(productDTO);
            return Ok(product);

        }
    }
}
