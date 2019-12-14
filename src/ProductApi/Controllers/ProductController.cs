using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetIdentity")]
        public IActionResult GetIdentity()
        {

            //return Ok(from c in User.Claims select new { c.Type, c.Value });
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "27 inc Monitor"
                },
                new Product
                {
                    Id =2,
                    Name = "Mekanik Klavye"
                }
            };

            return Ok(products);
        }
    }
}