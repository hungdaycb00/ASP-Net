using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaRazorPage.Data;
using PizzaRazorPage.Models;

namespace PizzaRazorPage.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly PizzaRazorPage.Data.PizzaRazorPageContext _context;

        private readonly IWebHostEnvironment WebHostEnvironment;

        public CreateModel(PizzaRazorPage.Data.PizzaRazorPageContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                
                //save image to wwwroot/image
                string wwwRootPath = WebHostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(Product.ImageFile.FileName);
                string extension = Path.GetExtension(Product.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                Product.Image = fileName;
                string path = Path.Combine(wwwRootPath + "/Image", fileName);
                using(var fileStream = new FileStream(path, FileMode.Create))
                {
                    await Product.ImageFile.CopyToAsync(fileStream);
                }
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
