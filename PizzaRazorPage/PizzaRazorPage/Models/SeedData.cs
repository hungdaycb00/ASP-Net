using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PizzaRazorPage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRazorPage.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PizzaRazorPageContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PizzaRazorPageContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "#1 MARGHERITA",
                        Image = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description= "Pizza với xốt cà chua và phomát.",
                        Price = 150M
                    },
                    new Product
                    {
                        Name = "#2 HAWAIIAN",
                        Image = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Price = 150M
                    },
                    new Product
                    {
                        Name = "#1 MARGHERITA",
                        Image = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Price = 150M
                    },
                    new Product
                    {
                        Name = "#2 HAWAIIAN",
                        Image = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Price = 150M
                    },
                    new Product
                    {
                        Name = "#1 MARGHERITA",
                        Image = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Price = 150M
                    },
                    new Product
                    {
                        Name = "#2 HAWAIIAN",
                        Image = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Price = 150M
                    },
                    new Product
                    {
                        Name = "#1 MARGHERITA",
                        Image = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Price = 150M
                    },
                    new Product
                    {
                        Name = "#2 HAWAIIAN",
                        Image = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Price = 150M
                    }
                    




                );
                context.SaveChanges();
            }
        }
    }
}
