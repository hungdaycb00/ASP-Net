using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProductManager.NongPhanManhHung.Models;
using ProductManager.NongPhanManhHung.Services;

namespace ProductManager.NongPhanManhHung.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileProductServices ProductService;

        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductServices productServices)
        {
            _logger = logger;
            ProductService = productServices;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
