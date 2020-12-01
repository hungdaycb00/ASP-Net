using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PizzaRazorPage.Data;
using PizzaRazorPage.Models;

namespace PizzaRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PizzaRazorPageContext _context;

        public IEnumerable<Product> GetProducts { get; set; }
        public IList<Product> Product { get; set; }

        public IndexModel(ILogger<IndexModel> logger,
            PizzaRazorPageContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGet()
        {
           GetProducts = await _context.Product.ToListAsync();
        }
    }
}
