using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaRazorPage.Models;

namespace PizzaRazorPage.Data
{
    public class PizzaRazorPageContext : DbContext
    {
        public PizzaRazorPageContext (DbContextOptions<PizzaRazorPageContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaRazorPage.Models.Product> Product { get; set; }
    }
}
