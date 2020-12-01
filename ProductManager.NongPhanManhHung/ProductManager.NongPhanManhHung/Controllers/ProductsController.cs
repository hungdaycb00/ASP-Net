using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManager.NongPhanManhHung.Models;
using ProductManager.NongPhanManhHung.Services;

namespace ProductManager.NongPhanManhHung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductServices productService)
        {
            this.ProductServices = productService;
        }
        public JsonFileProductServices ProductServices { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductServices.GetProducts();
        }
    }
}
