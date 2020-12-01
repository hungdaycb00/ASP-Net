﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaRazorPage.Data;
using PizzaRazorPage.Models;

namespace PizzaRazorPage.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly PizzaRazorPage.Data.PizzaRazorPageContext _context;

        public IndexModel(PizzaRazorPage.Data.PizzaRazorPageContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
